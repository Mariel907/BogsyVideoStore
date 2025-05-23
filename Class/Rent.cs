﻿using Microsoft.Reporting.WinForms;
using Project.Forms.ExtensionForms;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project.Class
{
    public class Rent
    {
        private DataLoader dataLoader = new DataLoader();
        public static List<Customers> Fullname()
        {
            List<Customers> customer = new List<Customers>();

            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Fullname", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        customer.Add(new Customers
                        {
                            CustomerID = reader["CustomerID"].ToString(),
                            Fullname = reader["Fullname"].ToString()
                        });
                    }
                }
            }
            return customer;
        }

        public static List<VideoProp> Video()
        {
            List<VideoProp> video = new List<VideoProp>();

            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Video", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        video.Add(new VideoProp
                        {
                            Title = reader["Title"].ToString(),
                            VideoId = int.Parse(reader["VideoID"].ToString()),
                            LimitDaysRented = int.Parse(reader["LimitDaysRented"].ToString()),
                            Price = Convert.ToDecimal(reader["Amount"].ToString()),
                            Category = reader["Category"].ToString().Trim(),
                            SerialNo = reader["SerialNo"].ToString(),
                            SerialID = int.Parse(reader["SerialID"].ToString())
                        });
                    }
                }
            }
            return video;
        }

        public static List<SrchSerial> SearchSerial(string txbx)
        {
            List<SrchSerial> Serial = new List<SrchSerial>();
            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SearchSerial", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchText", $"%{txbx}%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Serial.Add(new SrchSerial
                            {
                                Title = reader["Title"].ToString(),
                                SerialID = reader["SerialID"].ToString(),
                                SerialNo = reader["SerialNo"].ToString(),
                                VideoID = int.Parse(reader["VideoID"].ToString()),
                            });
                        }
                    }
                }
            }
            return Serial;
        }

        public void _InsertRent(Customers Customer, DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                int rentedDays = Convert.ToInt32(row.Cells["LimitDaysRented"].Value);
                int RentalID = AutoIncrementManager.GetNextRentalID();

                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("CustomerID", Customer.CustomerID),
                    new SqlParameter("VideoID", row.Cells["VideoID"].Value),
                    new SqlParameter("RentDate", DateTime.Now.Date),
                    new SqlParameter("Quantity", row.Cells["Quantity"].Value),
                    new SqlParameter("Price", row.Cells["Price"].Value),
                    new SqlParameter("Status", row.Cells["Status"].Value),
                    new SqlParameter("DueDate", DateTime.Now.Date.AddDays(rentedDays)),
                    new SqlParameter("RentalID", RentalID),
                    new SqlParameter("SerialID", row.Cells["SerialID"].Value),
                };
                dataLoader.ExecuteData("InsertRent", parameter);
            }
        }

        public void AddReceiptModel(ReportViewer reportViewer, Customers customerProp, DataGridView datagridView)
        {
            var list = new List<VideoProp>();

            foreach (DataGridViewRow row in datagridView.Rows)
            {
                var _video = new VideoProp();

                int rentedDays = Convert.ToInt32(row.Cells["LimitDaysRented"].Value);
                _video.VideoId = Convert.ToInt32(row.Cells["VideoID"].Value);
                _video.Title = row.Cells["Title"].Value.ToString();
                _video.LimitDaysRented = rentedDays;
                _video.Price = Convert.ToDecimal(row.Cells["Price"].Value);
                _video.Quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                _video.DueDate = DateTime.Now.Date.AddDays(rentedDays);
                _video.Category = row.Cells["Category"].Value.ToString();
                _video.SerialNo = row.Cells["SerialNo"].Value.ToString();

                list.Add(_video);
            }

            PrintReceipt print = new PrintReceipt(customerProp, list);
            print.ShowDialog();
        }

        public void Void(DataGridView dataGridView, string customerID)
        {
            int EntryNo = AutoIncrementManager.GetNextEntryNo();
            int RentalID = AutoIncrementManager.GetNextRentalID();
            string DocumentNo = AutoIncrementManager.GetNextDocumentNo();
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("CustomerID", customerID),
                new SqlParameter("RentDate", DateTime.Now.Date),
                new SqlParameter("Quantity", selectedRow.Cells["Quantity"].Value),
                new SqlParameter("VideoID", selectedRow.Cells["VideoID"].Value),
                new SqlParameter("Price", selectedRow.Cells["Price"].Value),
                new SqlParameter("Title", selectedRow.Cells["Title"].Value),
                new SqlParameter("DocumentNo", DocumentNo),
                new SqlParameter("SerialNo", selectedRow.Cells["SerialNo"].Value),
                new SqlParameter("EntryNo", EntryNo),
                new SqlParameter("SerialID", selectedRow.Cells["SerialID"].Value),
                new SqlParameter("RentalID", RentalID)
            };
            dataLoader.ExecuteData("Void", parameter);
        }

        public void SubtractTotalAmount(DataGridView dataGridView, string label, ref string _updatelabel)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                decimal TotalAmountToSubtract = 0;
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    TotalAmountToSubtract += Convert.ToDecimal(row.Cells["Price"].Value);
                    dataGridView.Rows.RemoveAt(row.Index);
                }
                decimal updateLabel = Convert.ToDecimal(label.Replace("P", "").ToString());

                updateLabel -= TotalAmountToSubtract;
                _updatelabel = "P" + updateLabel.ToString("N2");
            }
        }

        public void CheckedOut(SrchSerial Serial, VideoProp Video)
        {
            int entryNo = AutoIncrementManager.GetNextEntryNo();
            string DocumentNo = AutoIncrementManager.GetNextDocumentNo();

            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("VideoID", Video.VideoId),
                new SqlParameter("DocumentNo", DocumentNo),
                new SqlParameter("SerialNo", Serial.SerialNo),
                new SqlParameter("EntryNo", entryNo),
                new SqlParameter("SerialID", Serial.SerialID),
            };
            dataLoader.ExecuteData("CheckedOut", parameter);
        }

        public void CalculateChange(decimal totalAmount, decimal Cash, ref string Change)
        {
            decimal cashGiven = Cash;
            decimal change = cashGiven - totalAmount;
            Change = change.ToString("N2");
        }

        public void UpdateTotal(DataGridView datagridView, ref string Label)
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in datagridView.Rows)
            {
                if (row.Cells["Price"].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["Price"].Value);
                }
            }
            Label = "P" + totalAmount.ToString("N2");
        }
    }
}

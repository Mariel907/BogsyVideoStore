using Microsoft.Reporting.WinForms;
using Project.Forms.ExtensionForms;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public static List<SrchSerial> SearchSerial(string cmbx)
        {
            List<SrchSerial> Serial = new List<SrchSerial>();
            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SearchSerial", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@SearchText", $"%{cmbx}%");
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
                //int EntryNo =AutoIncrementManager.GetNextEntryNo();
                //string DocumwentNo = AutoIncrementManager.GetNextDocumentNo();

                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("CustomerID", Customer.CustomerID),
                    new SqlParameter("VideoID", row.Cells["VideoID"].Value),
                    new SqlParameter("RentDate", DateTime.Now.Date),
                    new SqlParameter("Quantity", row.Cells["Quantity"].Value),
                    new SqlParameter("TotalAmount", row.Cells["TotalAmount"].Value),
                    new SqlParameter("Price", row.Cells["Price"].Value),
                    new SqlParameter("Status", row.Cells["Status"].Value),
                    new SqlParameter("DueDate", DateTime.Now.Date.AddDays(rentedDays)),
                    //new SqlParameter("DocumentNo", DocumwentNo),
                    //new SqlParameter("EntryNo", EntryNo),
                    //new SqlParameter("Title", row.Cells["Title"].Value),
                    //new SqlParameter("SerialNo", Customer.SerialNo),
                    //new SqlParameter("Category", row.Cells["Category"].Value),
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
                _video.TotalAmount = Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                _video.SerialNo = row.Cells["SerialNo"].Value.ToString();

                list.Add(_video);
            }

            PrintReceipt print = new PrintReceipt(customerProp, list);
            print.ShowDialog();
        }

        public void Void(DataGridView dataGridView, string customerID)
        {
            int EntryNo = AutoIncrementManager.GetNextEntryNo();
            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("CustomerID", customerID),
                new SqlParameter("RentDate", DateTime.Now.Date),
                new SqlParameter("Quantity", selectedRow.Cells["Quantity"].Value),
                new SqlParameter("VideoID", selectedRow.Cells["VideoID"].Value),
                new SqlParameter("TotalAmount", selectedRow.Cells["TotalAmount"].Value),
                new SqlParameter("Price", selectedRow.Cells["Price"].Value),
                new SqlParameter("Title", selectedRow.Cells["Title"].Value),
                new SqlParameter("DocumentNo", selectedRow.Cells["DocumentNo"].Value),
                new SqlParameter("SerialNo", selectedRow.Cells["SerialNo"].Value),
                new SqlParameter("Category", selectedRow.Cells["Category"].Value),
                new SqlParameter("EntryNo", EntryNo)
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
                    TotalAmountToSubtract += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                    dataGridView.Rows.RemoveAt(row.Index);
                }
                decimal updateLabel = Convert.ToDecimal(label.Replace("P", "").ToString());

                updateLabel -= TotalAmountToSubtract;
                _updatelabel = "P" + updateLabel.ToString("N2");
            }
        }
        public void CheckedOut(VideoProp VideoID)
        {
            int entryNo = AutoIncrementManager.GetNextEntryNo();
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("VideoID", VideoID.VideoId),
                new SqlParameter("DocumentNo", VideoID.DocumentNo),
                new SqlParameter("Title", VideoID.Title),
                new SqlParameter("SerialNo", VideoID.SerialNo),
                new SqlParameter("Category", VideoID.Category),
                new SqlParameter("EntryNo", entryNo)

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
                if (row.Cells["TotalAmount"].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                }
            }
            Label = "P" + totalAmount.ToString("N2");
        }
    }
}

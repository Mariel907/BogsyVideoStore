using Microsoft.Reporting.WinForms;
using Project.Forms.ExtensionForms;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Project.Class
{
    public class Rent
    {
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
                            Category = reader["Category"].ToString()
                        });
                    }
                }
            }
            return video;
        }

        public void _InsertRent(Customers Customer, DataGridView dataGridView)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
            {
                connection.Open();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        SqlCommand cmd = new SqlCommand("InsertRent", connection, transaction);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CustomerID", Customer.CustomerID);
                        cmd.Parameters.AddWithValue("@VideoID", row.Cells["VideoID"].Value);
                        cmd.Parameters.AddWithValue("@RentDate", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@Quantity", row.Cells["Quantity"].Value);
                        cmd.Parameters.AddWithValue("@TotalAmount", row.Cells["TotalAmount"].Value);
                        cmd.Parameters.AddWithValue("@Price", row.Cells["Price"].Value);
                        cmd.Parameters.AddWithValue("@Status", row.Cells["Status"].Value);

                        int rentedDays = Convert.ToInt32(row.Cells["LimitDaysRented"].Value);
                        cmd.Parameters.AddWithValue("@DueDate", DateTime.Now.Date.AddDays(rentedDays));

                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public void AddReceiptModel(ReportViewer reportViewer, Customers customerProp, DataGridView datagridView)
        {
            var list = new List<VideoProp>();

            foreach(DataGridViewRow row in datagridView.Rows)
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

                list.Add(_video);
            }
            RentReceiptGenerator GntrReceipt = new RentReceiptGenerator(reportViewer);
            GntrReceipt.GenerateReceipt(customerProp, list);
        }

        public void Void(DataGridView dataGridView, string customerID)
        {
            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    SqlCommand cmd = new SqlCommand("Void", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("CustomerID", customerID);
                    cmd.Parameters.AddWithValue("RentDate", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("Quantity", row.Cells["Quantity"].Value);
                    cmd.Parameters.AddWithValue("VideoID", row.Cells["VideoID"].Value);
                    cmd.Parameters.AddWithValue("TotalAmount", row.Cells["TotalAmount"].Value);
                    cmd.Parameters.AddWithValue("Price", row.Cells["Price"].Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool TotalAmountToSubtract(DataGridView dataGridView, string label, ref string _updatelabel)
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
                return true;
            }
            else
                return false;
        }
        public void checkedOut(DataGridView dataGridView, VideoProp VideoID)
        {
            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("CheckedOut", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@VideoID", VideoID.VideoId);
                cmd.Parameters.AddWithValue("@Quantity", 1);

                cmd.ExecuteNonQuery();
            }
        }

        public void CalculateChange(decimal totalAmount, string Cash, ref string Change)
        {
            decimal cashGiven = Convert.ToDecimal(Cash);
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

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

        public Receipt _InsertRent(Customers Customer, DataGridView dataGridView)
        {
            Receipt receipt = new Receipt();
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
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

                                AddReceiptModel(receipt, row, rentedDays);
                            }

                            transaction.Commit();
                            receipt.CustomerName = Customer.Fullname;
                            receipt.RentDate = DateTime.Now;
                            receipt.Cash = Customer.Cash;
                            receipt.Change = Customer.Change;
                            //receipt.TotalAmount = receipt.RentedVideos.Sum(v => v.Price * v.Quantity);
                            //receipt.DueDate = DateTime.Now.AddDays(receipt.RentedVideos.Max(v => v.LimitDaysRented)); 

                            using (PrintReceipt print = new PrintReceipt(receipt, receipt.RentedVideos))
                            {
                                print.ShowDialog();
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.Message, "An error occurred during the transaction.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null;
                        }
                    }
                }
                return receipt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void AddReceiptModel(Receipt receipt, DataGridViewRow row, int rentedDays)
        {
            if (row.Cells["Status"].Value == null || row.Cells["Status"].Value.ToString() != "Void")
            {
                receipt.RentedVideos.Add(new VideoProp
                {
                    VideoId = Convert.ToInt32(row.Cells["VideoID"].Value),
                    Title = row.Cells["Title"].Value.ToString(),
                    LimitDaysRented = rentedDays,
                    Price = Convert.ToDecimal(row.Cells["Price"].Value),
                    Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                    DueDate = DateTime.Now.Date.AddDays(rentedDays),
                    Category = row.Cells["Category"].Value.ToString(),
                    TotalAmount = Convert.ToDecimal(row.Cells["TotalAmount"].Value)
                });
            }
        }

        public void   CalculateChange(decimal totalAmount, string Cash, ref string Change)
        {
            decimal cashGiven = Convert.ToDecimal(Cash);
            decimal change = cashGiven - totalAmount;
            Change = "P" + change.ToString("N2");
        }

        
    }
}

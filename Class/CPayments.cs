using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Class
{
    public class CPayments
    {
        public static List<SearchUnpaid> SearchUnpaid(string customerID)
        {
            List<SearchUnpaid> unpaid = new List<SearchUnpaid>();
            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SearchClientUnpaid", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", $"%{customerID}%");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            unpaid.Add(new SearchUnpaid
                            {
                                Title = reader["Title"].ToString(),
                                Penalty = reader["Penalty"].ToString(),
                                RentalID = reader["RentalID"].ToString(),
                                Category = reader["Category"].ToString(),
                                Qty = reader["Quantity"].ToString(),
                                Fullname = reader["Fullname"].ToString()

                            });
                        }
                    }
                }
            }
            return unpaid;
        }

        public static List<SearchUnpaid> ShowcmbCustomer()
        {
            List<SearchUnpaid> search = new List<SearchUnpaid>();
            HashSet<string> customerids = new HashSet<string>();

            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ShowcmbUnpaid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string customerID = reader["CustomerID"].ToString();
                        if (!customerids.Contains(customerID))
                        {
                            customerids.Add(customerID);
                            search.Add(new SearchUnpaid
                            {
                                Fullname = reader["Fullname"].ToString(),
                                CustomerID = reader["CustomerID"].ToString(),
                            });
                        }
                    }
                }
            }
            return search;
        }

        public void Closed(DataGridView dataGridView)
        {
            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();

                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    SqlCommand cmd = new SqlCommand("Closed", con);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@RentalID", row.Cells["RentalID"].Value);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTotal(DataGridView datagridView, ref string Label)
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in datagridView.Rows)
            {
                if (row.Cells["Penalty"].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["Penalty"].Value);
                }
            }
            Label = "P" + totalAmount.ToString("N2");
        }
    }
}

using Microsoft.Reporting.WinForms;
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
                                Fullname = reader["Fullname"].ToString(),
                                CustomerID = reader["CustomerID"].ToString()
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
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("@RentalID", row.Cells["RentalID"].Value)
                };
                DataLoader dataLoader = new DataLoader();
                dataLoader.ExecuteData("Closed", parameter);
            }
        }

        public void BtnUnpaid(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                SqlParameter[] parameter = new SqlParameter[]
                {
                    new SqlParameter("RentalID", row.Cells["RentalID"].Value)
                };
                DataLoader dataLoader = new DataLoader();
                dataLoader.ExecuteData("BtnUnpaid", parameter);
            }
        }
        public void BtnPaid(SearchUnpaid unpaid)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("RentalID", unpaid.RentalID)
            };
            DataLoader dataLoader = new DataLoader();
            dataLoader.ExecuteData("BtnPaid", parameter);
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
        public bool Confirmation(DataGridView dataGridView, string TxtxbxName, decimal TxbxCash, decimal TxbxChange, ReportViewer reportViewer, string cmbxFulname)
        {
            SearchUnpaid _penalty = new SearchUnpaid();
            if (dataGridView.Rows.Count > 0)
            {
                string existingCustomerID = dataGridView.Rows[0].Cells["CustomerID"].Value.ToString();
                string Name = dataGridView.Rows[0].Cells["Fullname"].Value.ToString();
                string NowID = TxtxbxName;

                if (existingCustomerID != NowID && NowID != null)
                {
                    MessageBox.Show($"The previous customer's name was {Name}, but it seems the name has changed. Please verify to ensure consistency.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            StoreRDLC(dataGridView, TxbxCash, TxbxChange, reportViewer, cmbxFulname);
            return true;
        }
        public void StoreRDLC(DataGridView datagridView, decimal TxbxCash, decimal TxbxChange, ReportViewer reportViewer, string cmbxFulname)
        {
            var list = new List<PenaltyReceipt>();
            foreach (DataGridViewRow row in datagridView.Rows)
            {
                var penalty = new PenaltyReceipt();
                penalty.RentalID = row.Cells["RentalID"].Value.ToString();
                penalty.Fullname = row.Cells["Fullname"].Value.ToString();
                penalty.Qty = row.Cells["Quantity"].Value.ToString();
                penalty.Title = row.Cells["Title"].Value.ToString();
                penalty.Category = row.Cells["Category"].Value.ToString();
                penalty.Penalty = Convert.ToDecimal(row.Cells["Penalty"].Value);

                list.Add(penalty);
            }
            ReceiptRDLC(list, TxbxCash, TxbxChange, reportViewer, cmbxFulname);
            Closed(datagridView);
            datagridView.Rows.Clear();
        }

        public void ReceiptRDLC(List<PenaltyReceipt> list, decimal TxbxCash, decimal TxbxChange, ReportViewer reportViewer, string cmbxFulname)
        {
            PenaltyReceipt penalty = new PenaltyReceipt
            {
                Cash = TxbxCash,
                Change = TxbxChange
            };

            PenaltyReceiptGenerator reportGenerator = new PenaltyReceiptGenerator(reportViewer);
            reportGenerator.GeneratePaymentReceipt(penalty, cmbxFulname, list);
        }

    }
}

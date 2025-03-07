using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
    public class CPayments
    {
        public List<SearchUnpaid> SearchUnpaid(string customerName)
        {
            List<SearchUnpaid> search = new List<SearchUnpaid>();

            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SearchClientUnpaid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Customername", "%" + customerName + "%");

                ShowcmbUnpaid();
                //using (SqlDataReader reader = cmd.ExecuteReader())
                //{
                //    while (reader.Read())
                //    {
                //        search.Add(new SearchUnpaid
                //        {
                //            Title = reader["Title"].ToString(),
                //            Fullname = reader["Fullname"].ToString(),
                //            CustomerID = reader["CustomerID"].ToString(),
                //            Category = reader["Category"].ToString(),
                //            Penalty = reader["Penalty"].ToString()
                //        });
                //    }
                //}
            }
            return search;
        }

        public static List<SearchUnpaid> ShowcmbUnpaid()
        {
            List<SearchUnpaid> search = new List<SearchUnpaid>();

            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ShowcmbUnpaid", con);
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        search.Add(new SearchUnpaid
                        {
                            Fullname = reader["Fullname"].ToString(),
                            CustomerID = reader["CustomerID"].ToString(),
                        });
                    }
                }
            }
            return search;
        }
    }
}

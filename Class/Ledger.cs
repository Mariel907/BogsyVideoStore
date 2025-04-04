using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    public class Ledger
    {
        public static List<MLedger> GetAllItemLedger()
        {
            var ItemLedger = new List<MLedger>();
            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("GetAllItemLedger", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var itemLedger = new MLedger()
                        {
                            DocumentNo = reader["DocumentNo"].ToString(),
                            Title = reader["Title"].ToString(),
                            Category = reader["Category"].ToString(),
                            SerialNo = reader["SerialNo"].ToString(),
                            Qty = int.Parse(reader["Qty"].ToString()),
                            LedType = reader["Type"].ToString()
                        };
                        ItemLedger.Add(itemLedger);
                    }
                }
                cmd.ExecuteNonQuery();
            }
            return ItemLedger;
        }
    }
}

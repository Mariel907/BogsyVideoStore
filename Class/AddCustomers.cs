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
    public class AddCustomers
    {
        public bool InsertCustomer(CustomerProp customer)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
                {
                    con.Open();
                    string query = "InsertCustomer";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", customer.LastName); 
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch(SqlException ex)
            {
                if (ex.Class == 16)
                    return false;
                else
                    throw;
            }
        }
    }
}

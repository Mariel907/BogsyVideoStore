using Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace Project.Class
{
    public class CustomerClass
    {
        public bool SaveEdit(CustomerProp cutomer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("UpdateCustomer", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FirstName", cutomer.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", cutomer.LastName);
                        cmd.Parameters.AddWithValue("@CustomerID", cutomer.CustomerID);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}

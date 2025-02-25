using Project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    public class Rent
    {
        public bool InsertRent(CustomerProp Customer)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertRent", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CustomerID", Customer.CustomerID);
                        cmd.Parameters.AddWithValue("@VideoID", Customer.VideoID);
                        cmd.Parameters.AddWithValue("@RentDate", DateTime.Now.Date);

                        if (Customer.LimitDaysRented == "1")
                            cmd.Parameters.AddWithValue("@Duedate", DateTime.Now.AddDays(1));
                        else if (Customer.LimitDaysRented == "2")
                            cmd.Parameters.AddWithValue("@Duedate", DateTime.Now.AddDays(2));
                        else if (Customer.LimitDaysRented == "3")
                            cmd.Parameters.AddWithValue("@Duedate", DateTime.Now.AddDays(3));

                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

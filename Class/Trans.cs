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
    public class Trans
    {
        public void Return(Transac transac)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateReturn", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VideoID", transac.VideoID);
                    cmd.Parameters.AddWithValue("@RentalID", transac.RentalId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

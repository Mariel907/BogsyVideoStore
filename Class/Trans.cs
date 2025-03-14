using Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace Project.Class
{
    public class Trans
    {
        public bool Return(Transac transac)
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
            return true;
        }

        public void SearchCategory()
        {

        }
    }
}

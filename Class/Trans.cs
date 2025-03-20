using Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace Project.Class
{
    public class Trans
    {
        public void Return(Transac transac)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@VideoID", transac.VideoID),
                new SqlParameter("@RentalID", transac.RentalId)
            };
            DataLoader ds = new DataLoader();
            ds.ExecuteData("UpdateReturn", parameter);
        }
    }
}

using Project.Model;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Class
{
    public class Trans
    {
        private DataLoader ds = new DataLoader();

        public void Return(Transac transac)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@VideoID", transac.VideoID),
                new SqlParameter("@RentalID", transac.RentalId)
            };
            ds.ExecuteData("UpdateReturn", parameter);
        }
        public void RefreshSearchCMBXRented(string SDate, string EDate, string Cmbx, DataGridView dt)
        {
            string query = string.Empty;
            SqlParameter[] parameter;
            if (Cmbx == "DVD")
            {
                query = "GetAllRentedDVD";
                parameter = new SqlParameter[]
                {
                    new SqlParameter("StartDate", SDate),
                    new SqlParameter("EndDate", EDate)
                };
            }
            else
            {
                query = "GetAllRentedVCD";
                parameter = new SqlParameter[]
                {
                    new SqlParameter("StartDate", SDate),
                    new SqlParameter("EndDate", EDate)
                };
            }

            ds.LoadData(query, dt);
        }

        public void RefreshSearchCMBXTxbxRented(string SDate, string EDate, string cmbx, string Txbx, DataGridView dt)
        {
            string query = string.Empty;
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("SearchText", Txbx),
                new SqlParameter("StartDate", SDate),
                new SqlParameter("EndDate", EDate),
                new SqlParameter("Category", cmbx)
            };
            ds.LoadData("GetAllRentedTxbxDVD", dt, parameter);
        }
    }
}

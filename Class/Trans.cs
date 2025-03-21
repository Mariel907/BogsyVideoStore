using Project.Model;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
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
        public void RefreshSearchCMBXRented(string Cmbx, DataGridView dt)
        {
            string query = string.Empty;
            if (Cmbx == "DVD")
                query = "GetAllRentedDVD";
            else
                query = "GetAllRentedVCD";

            ds.LoadData(query, dt);
        }

        public void RefreshSearchCMBXTxbxRented(string cmbx, string Txbx, DataGridView dt)
        {
            string query = string.Empty;
            SqlParameter[] parameter;
            if (cmbx == "DVD" && !string.IsNullOrEmpty(Txbx))
            {
                query = "GetAllRentedTxbxDVD";
                parameter = new SqlParameter[]
                {
                    new SqlParameter("@SearchText", Txbx)
                };
            }
            else
            {
                query = "GetAllRentedTxbxVCD";
                parameter = new SqlParameter[]
                {
                    new SqlParameter("@SearchText", Txbx)
                };
            }
            ds.LoadData(query, dt, parameter);
        }
    }
}

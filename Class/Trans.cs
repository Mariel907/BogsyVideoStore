using Project.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
    public class Trans
    {
        public bool Return(Transac transac)
        {
            try
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
            catch (Exception)
            {
                return false;
            }
        }

        public void SearchCMB(int? month, int? year, DataGridView datagrid)
        {
            string query;
            SqlParameter[] parameters;
            HiddenColumn hidden = new HiddenColumn();
            if (month != null && month != 0 && year != 0)
            {
                query = "SearchYearMonth";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Month", month),
                    new SqlParameter("@Year", year)
                };
            }
            else if (year != 0)
            {
                query = "SearchYear";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Year", year),
                };
            }
            else if (month != 0)
            {
                query = "SearchMonth";
                parameters = new SqlParameter[]
                {
                    new SqlParameter("@Month", month)
                };
            }
            else
            {
                return;
            }

            DataLoader dataLoader = new DataLoader();
            dataLoader.LoadData(query, datagrid, true, parameters);
        }
    }
}

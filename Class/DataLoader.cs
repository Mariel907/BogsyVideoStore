using Project.Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Class
{
    public class DataLoader
    {
        public void LoadData(string query, DataGridView datagridView = null, bool isStoredProcedure = true, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(GlobalConnection.Connection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (isStoredProcedure)
                        cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                        SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        Adapter.Fill(dataTable);
                    if (datagridView != null)
                    {
                        datagridView.DataSource = dataTable; 
                    }
                }
            }
        }

        public void Reports(DataGridView dataGridView)
        {
            string query = "Reports";
            LoadData(query, dataGridView);
        }
    }
}

using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Class
{
    public class SearchReports
    {
        private DataLoader dataLoader = new DataLoader();
        public void SearchTxbxReports(string txbx, string cmbx, DataGridView dgv)
        {
            SearchTxbx("SearchReportsTxbx", "SearchReportsTxbxInCmbx", cmbx, txbx, dgv);
        }

        public void SearchCmbxReports(string cmbx, DataGridView dgv)
        {
            searchCmbx("SearchReportsCmbx", cmbx, dgv);
        }
        public void searchCmbx(string Query, string cmbx, DataGridView dataGridView)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("Category", cmbx)
            };
            dataLoader.LoadData(Query, dataGridView, parameter);
        }

        public void SearchTxbx(string EQuery, string nQuery, string cmbx, string searchtext, DataGridView dataGridView)
        {
            string query = string.IsNullOrEmpty(cmbx)
                ? EQuery
                : nQuery;

            SqlParameter[] parameter = string.IsNullOrEmpty(cmbx)
                ? new SqlParameter[]
                {
                    new SqlParameter("SearchText", searchtext)
                }
                : new SqlParameter[]
                {
                    new SqlParameter("Category", cmbx),
                    new SqlParameter("SearchText", searchtext)
                };
            dataLoader.LoadData(query, dataGridView, parameter);
        }
    }
}

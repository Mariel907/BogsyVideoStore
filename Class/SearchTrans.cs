using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
    public class SearchTrans
    {
        DataLoader dataLoader = new DataLoader();
        public void SearchCmbxRented(string cmbx, DataGridView dataGridView)
        {
            searchCmbx("SearchCmbxRented", cmbx, dataGridView);
        }
        public void SearchCmbxReturned(string cmbx, DataGridView dataGridView)
        {
            searchCmbx("SearchcmbxReturned", cmbx, dataGridView);
        }

        private void searchCmbx(string Query, string cmbx, DataGridView dataGridView)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("Category", cmbx)
            };
            dataLoader.LoadData(Query, dataGridView, true, parameter);
        }

        public void SearchTxbxRented(string cmbx, string searchtext, DataGridView dataGridView)
        {
            SearchTxbx("SearchtxbxRented", "SearchcmbxInTxbxRented", cmbx, searchtext, dataGridView);
        }
        public void SearchTxbxReturned(string cmbx, string searchtext, DataGridView dataGridView)
        {
            SearchTxbx("SearchTxbxReturned", "SearchcmbxInTxbxReturned", cmbx, searchtext, dataGridView);
        }

        private void SearchTxbx(string EQuery, string nQuery, string cmbx, string searchtext, DataGridView dataGridView)
        {
            string query;
            SqlParameter[] parameter;
            if (string.IsNullOrEmpty(cmbx))
            {
                query = EQuery;
                parameter = new SqlParameter[]
                {
                    new SqlParameter("SearchText", searchtext)
                };
            }
            else
            {
                query = nQuery;
                parameter = new SqlParameter[]
                {
                    new SqlParameter("Category", cmbx),
                    new SqlParameter("SearchText", searchtext)
                };
            }
            dataLoader.LoadData(query, dataGridView, true, parameter);
        }
    }
}

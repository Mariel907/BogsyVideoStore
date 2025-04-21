using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Project.Class
{
    public class CEFRented
    {
        private DataLoader dataLoader = new DataLoader();
        public void SearchRented(string cmbx, string txbx, DataGridView DGV)
        {
            Search("SearchEFRented", cmbx, txbx, DGV);
        }

        public void SearchReturned(string cmbx, string txbx, DataGridView DGV)
        {
            Search("SearchEFReturned", cmbx, txbx, DGV);
        }
        public void SearchTotalVidoe(string cmbx, string txbx, DataGridView DGV)
        {
            Search("SearchEFTotalVideo", cmbx, txbx, DGV);
        }
        public void SearchAvailableVidoe(string cmbx, string txbx, DataGridView DGV)
        {
            Search("SearchEFAvailaleVideo", cmbx, txbx, DGV);
        }
        public void SearchDueRent(string cmbx, string txbx, DataGridView DGV)
        {
            Search("SearchEFOverdueRent", cmbx, txbx, DGV);
        }
        public void Search(string Query,string cmbx, string txbx, DataGridView DGV)
        {
            string query = Query;
            List<SqlParameter> parameters = new List<SqlParameter>();

            string key = (string.IsNullOrEmpty(cmbx) ? "empty" : "filled") + "-" + (string.IsNullOrEmpty(txbx) ? "empty" : "filled");

            switch (key)
            {
                case "empty-empty":
                    parameters.Add(new SqlParameter("Action", "All"));
                    break;

                case "filled-empty":
                    parameters.Add(new SqlParameter("Category", cmbx));
                    parameters.Add(new SqlParameter("Action", "cmbx"));
                    break;

                case "empty-filled":
                    parameters.Add(new SqlParameter("Txbx", txbx));
                    parameters.Add(new SqlParameter("Action", "Txbx"));
                    break;

                case "filled-filled":
                    parameters.Add(new SqlParameter("Txbx", txbx));
                    parameters.Add(new SqlParameter("Category", cmbx));
                    parameters.Add(new SqlParameter("Action", "CmbxTxbx"));
                    break;

                default:
                    throw new InvalidOperationException("Unexpected state for cmbx and txbx.");
            }

            dataLoader.LoadData(query, DGV, parameters.ToArray());
        }
    }
}

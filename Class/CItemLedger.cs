using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
    public class CItemLedger
    {
        private DataLoader Dl = new DataLoader();

        public void SearchDVDTxbxItemLedger(string txbx, string cmbx, DataGridView DGV)
        {
            string query = string.Empty;
            List<SqlParameter> parameters = new List<SqlParameter>();   

            string key =(string.IsNullOrEmpty(cmbx)  ? "empty" : "filled") + "-" + (string.IsNullOrEmpty(txbx) ? "empty" : "filled");

            switch(key)
            {
                case "filled-empty":
                    query = "SearchDVDItemLedger";
                    parameters.Add(new SqlParameter("Category", cmbx));
                    break;
                case "empty-filled":
                    query = "SearchTxbxItemLedger";
                    parameters.Add(new SqlParameter("SearchText", txbx));
                    break;
                case "filled-filled":
                    query = "SearchDVDTxbxItemLedger";
                    parameters.Add(new SqlParameter("Category",cmbx));
                    parameters.Add(new SqlParameter("SearchText", txbx));
                    break;
                case "empty-empty":
                    query = "GetAllItemLedger";
                    break;
                default:
                    throw new InvalidOperationException("Unexpected state for cmbx and txbx.");
            }
            Dl.LoadData(query, DGV, parameters.ToArray());
        }
    }
}

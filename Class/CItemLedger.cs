using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Class
{
    public class CItemLedger
    {

        public void SearchDVDTxbxItemLedger(string txbx, string cmbx, DataGridView DGV, string cmbxType, string EndDate, string StartDate)
        {
            string query = string.Empty;
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("StartDate", StartDate),
                new SqlParameter("EndDate", EndDate)
            };

            string key = (string.IsNullOrEmpty(cmbx) ? "empty" : "filled") + "-" +
                (string.IsNullOrEmpty(txbx) ? "empty" : "filled") + "-" +
                (string.IsNullOrEmpty(cmbxType) ? "empty" : "filled");

            switch (key)
            {
                case "filled-empty-empty":
                    query = "SearchDVDItemLedger";
                    parameters.Add(new SqlParameter("Category", cmbx));
                    break;
                case "empty-filled-empty":
                    query = "SearchTxbxItemLedger";
                    parameters.Add(new SqlParameter("SearchText", txbx));
                    break;
                case "filled-filled-empty":
                    query = "SearchDVDTxbxItemLedger";
                    parameters.Add(new SqlParameter("Category", cmbx));
                    parameters.Add(new SqlParameter("SearchText", txbx));
                    break;
                case "empty-empty-empty":
                    query = "GetAllItemLedger";
                    break;
                case "empty-empty-filled":
                    query = "SearchType";
                    parameters.Add(new SqlParameter("Type", cmbxType));
                    break;
                case "filled-empty-filled":
                    query = "SearchCmbxType";
                    parameters.Add(new SqlParameter("Type", cmbxType));
                    parameters.Add(new SqlParameter("Category", cmbx));
                    break;
                case "filled-filled-filled":
                    query = "SearchCmbxTxbxType";
                    parameters.Add(new SqlParameter("Type", cmbxType));
                    parameters.Add(new SqlParameter("Category", cmbx));
                    parameters.Add(new SqlParameter("SearchText", txbx));
                    break;
                default:
                    throw new InvalidOperationException("Unexpected state for cmbx and txbx.");
            }
            DataLoader Dl = new DataLoader();
            Dl.LoadData(query, DGV, parameters.ToArray());
        }
    }
}

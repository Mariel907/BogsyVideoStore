using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Project.Class
{
    public class SearchVideo
    {
        DataLoader dataLoader = new DataLoader();
        public void SearchCmbxTxbx(string txbx, string cmbx, DataGridView DGV)
        {
            string query;
            List<SqlParameter> parameter = new List<SqlParameter>();

            string key = (string.IsNullOrEmpty(cmbx) ? "empty" : "filled") + "-" + (string.IsNullOrEmpty(txbx) ? "empty" : "filled");

            switch(key)
            {
                case "filled-empty":
                    query = "SearchCmbxVideo";
                    parameter.Add(new SqlParameter("Category", cmbx));
                    break;
                case "empty-filled":
                    query = "SearchTxbxVideo";
                    parameter.Add(new SqlParameter("SearchText", txbx));
                    break;
                case "filled-filled":
                    query = "SearchCmbxTxbxVideo";
                    parameter.Add(new SqlParameter("Category", cmbx));
                    parameter.Add(new SqlParameter("SearchText", txbx));
                    break;
                case "empty-empty":
                    query = "GetAllVideo";
                    break;
                default:
                    throw new InvalidOperationException("Unexpected state for cmbx and txbx.");
            }
            dataLoader.LoadData(query, DGV, parameter.ToArray());
        }
    }
}

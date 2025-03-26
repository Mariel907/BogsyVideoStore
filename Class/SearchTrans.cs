using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Class
{
    public class SearchTrans
    {
        DataLoader dataLoader = new DataLoader();

        public void SearchDate(string txbx, string cmbx, string SDate, string EDate, DataGridView DGV)
        {
            string query;
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("StartDate", SDate),
                new SqlParameter("EndDate", EDate)
            };

            string key = (string.IsNullOrEmpty(cmbx) ? "empty" : "filled") + "-" + (string.IsNullOrEmpty(txbx) ? "empty" : "filled");

            switch(key)
            {
                case "empty-empty":
                    query = "SearchRentDateDTP";
                    break;

                case "filled-empty":
                    query = "SearchRentDateDTPcmbx";
                    parameters.Add(new SqlParameter("Category", cmbx));
                    break;

                case "empty-filled":
                    query = "SearchRentDateDTPTxbx";
                    parameters.Add(new SqlParameter("SearchText", txbx));
                    break;

                case "filled-filled":
                    query = "SearchRentDateDTPcmbxTxbx";
                    parameters.Add(new SqlParameter("Category", cmbx));
                    parameters.Add(new SqlParameter("SearchText", txbx));
                    break;

                default:
                    throw new InvalidOperationException("Unexpected state for cmbx and txbx.");
            }    
            dataLoader.LoadData(query, DGV, parameters.ToArray());
        }

        public void searchDateReturned(string cmbx, string txbx, string SDate, string EDate, DataGridView DGV)
        {
            string query;
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("StartDate", SDate),
                new SqlParameter("EndDate", EDate)
            };

            string key = (string.IsNullOrEmpty(cmbx) ? "empty" : "filled") + "-" + (string.IsNullOrEmpty(txbx) ? "empty" : "filled");

            switch (key)
            {
                case "empty-empty":
                    query = "SearchReturnDTP";
                    break;

                case "filled-empty":
                    query = "SearchcmbxReturned";
                    parameters.Add(new SqlParameter("Category", cmbx));
                    break;

                case "empty-filled":
                    query = "SearchTxbxReturned";
                    parameters.Add(new SqlParameter("SearchText", txbx));
                    break;

                case "filled-filled":
                    query = "SearchReturnDTPTxbxCmbx";
                    parameters.Add(new SqlParameter("SearchText", txbx));
                    parameters.Add(new SqlParameter("Category", cmbx));
                    break;

                default:
                    throw new InvalidOperationException("Unexpected state for cmbx and txbx.");
            }

            dataLoader.LoadData(query, DGV, parameters.ToArray());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Class
{
    public class SearchTrans
    {
        DataLoader dataLoader = new DataLoader();
        //private void SearchDate()
        //{
        //    DateTime date = dateTimePicker1.Value;
        //    cmbx = guna2ComboBoxRented.Text;
        //    txbx = guna2TextBoxCheckedOut.Text;

        //    search.SearchDate(txbx, cmbx, date, guna2DataGridViewRented);
        //}
        //public void SearchDate(string txbx, string cmbx, DateTime Date, DataGridView DGV)
        //{
        //    string query;
        //    List<SqlParameter> parameters = new List<SqlParameter>
        //    {
        //        new SqlParameter("Date", Date) 
        //    };

        //    if (string.IsNullOrEmpty(cmbx) && string.IsNullOrEmpty(txbx))
        //    {
        //        query = "SearchRentDateDTP";
        //    }
        //    else if (!string.IsNullOrEmpty(cmbx) && string.IsNullOrEmpty(txbx))
        //    {
        //        query = "SearchRentDateDTPcmbx";
        //        parameters.Add(new SqlParameter("Category", cmbx));
        //    }
        //    else if (!string.IsNullOrEmpty(txbx) && string.IsNullOrEmpty(cmbx))
        //    {
        //        query = "SearchRentDateDTPTxbx";
        //        parameters.Add(new SqlParameter("SearchText", txbx));
        //    }
        //    else
        //    {
        //        query = "SearchRentDateDTPcmbxTxbx";
        //        parameters.Add(new SqlParameter("Category", cmbx));
        //        parameters.Add(new SqlParameter("SearchText", txbx));
        //    }

        //    dataLoader.LoadData(query, DGV, parameters.ToArray());
        //}

        public void SearchCmbxRented(string cmbx, DataGridView dataGridView)
        {
            searchCmbx("SearchCmbxRented", cmbx, dataGridView);
        }

        public void SearchCmbxReturned(string cmbx, DataGridView dataGridView)
        {
            searchCmbx("SearchcmbxReturned", cmbx, dataGridView);
        }

        public void searchCmbx(string Query, string cmbx, DataGridView dataGridView)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("Category", cmbx)
            };
            dataLoader.LoadData(Query, dataGridView, parameter);
        }

        public void SearchTxbxRented(string cmbx, string searchtext, DataGridView dataGridView)
        {
            SearchTxbx("SearchtxbxRented", "SearchcmbxInTxbxRented", cmbx, searchtext, dataGridView);
        }
        public void SearchTxbxReturned(string cmbx, string searchtext, DataGridView dataGridView)
        {
            SearchTxbx("SearchTxbxReturned", "SearchcmbxInTxbxReturned", cmbx, searchtext, dataGridView);
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
    public class HiddenColumn
    {
        private void HideID(DataGridView DGV, List<string> columnsHIde)
        {
            foreach (var column in columnsHIde)
            {
                if(DGV.Columns.Contains(column))
                    DGV.Columns[column].Visible = false;
            }
        }

        private void HideVisibleID(DataGridView dataGridView, string query, List<string> columnsHide, SqlParameter[] parameter = null)
        {
            DataLoader dataLoader = new DataLoader();
            dataLoader.LoadData(query, dataGridView, true, parameter);
            HideID(dataGridView, columnsHide);
        }

        public void Unpaid(DataGridView datagridView)
        {
            HideVisibleID(datagridView, "Unpaid", new List<string> { "RentalID", "CustomerID", "VideoID", });
        }

        public void GetAllCustomer(DataGridView datagridView)
        {
            HideVisibleID(datagridView, "GetAllCustomer", new List<string> { "CustomerID" });
        }
        
        public void GetAllRental(DataGridView dataGrid)
        {
            HideVisibleID(dataGrid, "GetAllRental", new List<string> { "RentalID", "CustomerID", "VideoID", });
        }
        public void GetAllDVD(DataGridView dataGrid)
        {
            HideVisibleID(dataGrid, "GetAllDVD", new List<string> { "VideoID" });
        }
        public void GetAllVCD(DataGridView dataGrid)
        {
            HideVisibleID(dataGrid, "GetAllVCD", new List<string> { "VideoID" });
        }
        public void GetAllReturned(DataGridView dataGrid)
        {
            HideVisibleID(dataGrid, "GetAllReturned", new List<string> { "RentalID", "CustomerID", "VideoID", });
        }
    }
}

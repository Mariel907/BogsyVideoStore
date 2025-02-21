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

        public void GetAllCustomer(DataGridView datagridView)
        {
            HideVisibleID(datagridView, "GetAllCustomer", new List<string> { "CustomerID" });
        }
        public void GetAllVideo(DataGridView datagridView)
        {
            HideVisibleID(datagridView, "GetAllVideo", new List<string> { "VideoID", "Director", "Rating", "ReleaseDate", "CopiesAvailable"});
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
   public class SearchCustomer
    {
        DataLoader dataLoader = new DataLoader();
        public void SearchTxbxCustomer(string searchtext, DataGridView dataGridView)
        {
            dataLoader.SearchTxbx("SearchTxbxCustomer", searchtext, dataGridView);
        }
    }
}

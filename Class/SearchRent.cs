using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
    public class SearchRent
    {
        DataLoader dataLoader = new DataLoader();
        public void SearchTxbxRentCustomer(string txbx, DataGridView dataGridView)
        {
            dataLoader.SearchTxbx("SearchTxbxRentCustomer", txbx, dataGridView);
        }
    }
}

using Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms.DashboardForms
{
    public partial class EFReturned : Form
    {
        public EFReturned()
        {
            InitializeComponent();
        }

        private void EFReturned_Load(object sender, EventArgs e)
        {
            DGVReturned.DataSource = CEFDashboard.GetMReturned();
        }

        private void G2TxbxReturned_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void G2CmbxReturned_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            CEFRented cEFRented = new CEFRented();
            string cmbx = G2CmbxReturned.Text;
            string txbx = G2TxbxReturned.Text;
            cEFRented.SearchReturned(cmbx, txbx, DGVReturned);
        }
    }
}

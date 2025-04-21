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
    public partial class EFDueRent : Form
    {
        public EFDueRent()
        {
            InitializeComponent();
        }

        private void EFDueRent_Load(object sender, EventArgs e)
        {
            DGVDueRent.DataSource = CEFDashboard.GetAllDueRent();
        }

        private void G2CmbxDueDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void G2TxbxDueDate_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            CEFRented cEFRented = new CEFRented();
            string txbx = G2TxbxDueDate.Text;
            string cmbx = G2CmbxDueDate.Text;
            cEFRented.SearchDueRent(cmbx, txbx, DGVDueRent);
        }
    }
}

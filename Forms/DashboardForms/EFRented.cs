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
    public partial class EFRented : Form
    {
        public EFRented()
        {
            InitializeComponent();
        }

        private void EFRented_Load(object sender, EventArgs e)
        {
            DGVRented.DataSource = CEFDashboard.GetAllRented();
        }

        private void G2TxbxRented_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void G2CmbxRented_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            CEFRented cEFRented = new CEFRented();
            string cmbx = G2CmbxRented.Text;
            string txbx = G2TxbxRented.Text;
            cEFRented.SearchRented(cmbx, txbx, DGVRented);
        }

    }
}

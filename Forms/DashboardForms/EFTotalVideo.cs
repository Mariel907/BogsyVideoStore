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
    public partial class EFTotalVideo : Form
    {
        public EFTotalVideo()
        {
            InitializeComponent();
        }

        private void EFTotalVideo_Load(object sender, EventArgs e)
        {
            DGVTotalVideo.DataSource = CEFDashboard.GetAllTotalVideo();
        }

        private void G2TxbxTotalVideo_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void G2CmbxTotalVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            CEFRented cEFRented = new CEFRented();
            string cmbx = G2CmbxTotalVideo.Text;
            string txbx = G2TxbxTotalVideo.Text;
            cEFRented.SearchTotalVidoe(cmbx, txbx, DGVTotalVideo);
        }
    }
}

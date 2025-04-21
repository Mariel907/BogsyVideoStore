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
    public partial class EFAvailableVideo : Form
    {
        public EFAvailableVideo()
        {
            InitializeComponent();
        }

        private void EFAvailableVideo_Load(object sender, EventArgs e)
        {
            DGVAvailableVideo.DataSource = CEFDashboard.GetAllAvailableVideo();
        }

        private void G2TxbxAvailableVideo_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void G2CmbxAvailableVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            CEFRented cEFRented = new CEFRented();
            string cmbx = G2CmbxAvailableVideo.Text;
            string Txbx = G2TxbxAvailableVideo.Text;
            cEFRented.SearchAvailableVidoe(cmbx, Txbx, DGVAvailableVideo);
        }
    }
}

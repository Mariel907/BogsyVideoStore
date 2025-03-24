using Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class DGVReports : Form
    {
        private SearchReports search = new SearchReports();

        public DGVReports()
        {
            InitializeComponent();
        }

        private void DGVReports_Load(object sender, EventArgs e)
        {
            this.reportsTableAdapter.Fill(this.dSReports.Reports);
        }

        private void guna2TextBoxReports_TextChanged(object sender, EventArgs e)
        {
            string txbx = guna2TextBoxReports.Text;
            string cmbx = guna2ComboBoxReports.Text;
            search.SearchTxbxReports(txbx, cmbx, guna2DataGridViewReports);
        }

        private void guna2ComboBoxReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmbx = guna2ComboBoxReports.Text;
            search.SearchCmbxReports(cmbx, guna2DataGridViewReports);
        }
    }
}

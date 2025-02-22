using Project.Class;
using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class RentCustomer : Form
    {
        private Dashboard dashboard;

        public RentCustomer(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void guna2ButtonSave_Click(object sender, EventArgs e)
        {

            Video vd = new Video(dashboard);
            CustomerProp customerProp = new CustomerProp();
            customerProp.CustomerID = guna2TextBoxCustomerID.Text;
            customerProp.VideoID = guna2TextBoxID.Text;
            vd.InsertCustomer(customerProp);
        }

        private void RentCustomer_Load(object sender, EventArgs e)
        {
            HiddenColumn hide = new HiddenColumn();
            hide.GetAllVideo(dgvDVDs__VCDs);
            hide.GetAllCustomer(guna2DataGridViewCustomer);
        }

        private void RentCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvDVDs__VCDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvDVDs__VCDs.SelectedRows[0];
            guna2TextBoxID.Text = selectedRow.Cells["VideoID"].Value.ToString();
        }

        private void guna2DataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = guna2DataGridViewCustomer.SelectedRows[0];
            guna2TextBoxCustomerID.Text = selectedRow.Cells["CustomerID"].Value.ToString();
            guna2TextBoxFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
            guna2TextBoxLastName.Text = selectedRow.Cells["LastName"].Value.ToString();
        }
    }
}

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
            customerProp.FirstName = guna2TextBoxFirstName.Text;
            customerProp.LastName = guna2TextBoxLastName.Text;
            vd.InsertCustomer(customerProp);
        }

        private void guna2TextBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void RentCustomer_Load(object sender, EventArgs e)
        {
            HiddenColumn hide = new HiddenColumn();
            hide.GetAllVideo(dgvDVDs__VCDs);
        }

        private void dgvDVDs__VCDs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvDVDs__VCDs.SelectedRows[0];
            guna2TextBoxID.Text = selectedRow.Cells["VideoID"].Value.ToString();
        }

        private void guna2DataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvDVDs__VCDs.SelectedRows[0];
            guna2TextBoxCustomerID.Text = selectedRow.Cells["CustomerID"].Value.ToString();
            guna2TextBoxFirstName.Text = selectedRow.Cells["FirstName"].Value.ToString();
            guna2TextBoxFirstName.Text = selectedRow.Cells["LastName"].Value.ToString();
        }
    }
}

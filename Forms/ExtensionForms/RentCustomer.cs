using Project.Class;
using Project.Model;
using System;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class RentCustomer : Form
    {
        public RentCustomer()
        {
            InitializeComponent();
        }

        private void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();

            CustomerProp customerProp = new CustomerProp();
            customerProp.CustomerID = guna2TextBoxCustomerID.Text;
            customerProp.VideoID = guna2TextBoxID.Text;
            customerProp.LimitDaysRented = guna2TextBoxDaysRented.Text;

            bool isRented = rent.InsertRent(customerProp);

            if (isRented)
            {
                MessageBox.Show("Video rented successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guna2TextBoxPrice.Text = string.Empty;
                guna2TextBoxID.Text = string.Empty;
                guna2TextBoxCustomerID.Text = string.Empty;
                guna2TextBoxLastName.Text = string.Empty;
                guna2TextBoxFirstName.Text = string.Empty;
                guna2TextBoxDaysRented.Text = string.Empty;
            }
            else
                MessageBox.Show("An error occured during renting. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            guna2TextBoxPrice.Text = selectedRow.Cells["Price"].Value.ToString();
            guna2TextBoxDaysRented.Text = selectedRow.Cells["LimitDaysRented"].Value.ToString();
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

using Project.Class;
using Project.Model;
using System;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class EditCustomer : Form
    {
        private CustomerProp _customerProp;
        public EditCustomer(CustomerProp customerProp)
        {
            InitializeComponent();
            _customerProp = customerProp;
            guna2TextBoxFirstname.Text = _customerProp.FirstName;
            guna2TextBoxLastName.Text = _customerProp.LastName;
            guna2TextBoxID.Text = _customerProp.CustomerID;
        }

        private void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            CustomerProp customerProp = new CustomerProp();
            customerProp.FirstName = guna2TextBoxFirstname.Text;
            customerProp.LastName = guna2TextBoxLastName.Text;
            customerProp.CustomerID = guna2TextBoxID.Text;

            CustomerClass customer = new CustomerClass();
            bool isEdit = customer.SaveEdit(customerProp);

            if (isEdit)
                MessageBox.Show("Data updated successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An error occured during updating. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EditCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

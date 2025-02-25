using Project.Class;
using Project.Model;
using System;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Guna2ButtonSave_Click(object sender, EventArgs e)
        {
            CustomerProp customerprop = new CustomerProp();
            customerprop.FirstName = guna2TextBoxFirstname.Text;
            customerprop.LastName = guna2TextBoxLastName.Text;

            AddCustomers add = new AddCustomers();
            bool isInserted = add.InsertCustomer(customerprop);

            if (isInserted)
                MessageBox.Show("Data added successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Duplicate entry detected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void AddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

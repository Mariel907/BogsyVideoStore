using Project.Class;
using Project.Forms.ExtensionForms;
using Project.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class CustomerForm : Form
    {
        private SearchCustomer search = new SearchCustomer();

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void Guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelEdit.Visible = true;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            CustomerLoad();
        }
        private void CustomerLoad()
        {
            this.getAllCustomerTableAdapter.Fill(this.dSReports.GetAllCustomer);
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Guna2TextBoxCustomer_TextChanged(object sender, EventArgs e)
        {
            string txbx = guna2TextBoxCustomer.Text;
            search.SearchTxbxCustomer(txbx, guna2DataGridViewCustomer);
        }

        private void Guna2ButtonCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerProp customerprop = new CustomerProp();
                customerprop.FirstName = guna2TextBoxFirstname.Text;
                customerprop.LastName = guna2TextBoxLastName.Text;

                AddCustomers add = new AddCustomers();
                add.InsertCustomer(customerprop);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            CustomerLoad();
        }

        private void Guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
            panelEdit.Visible = false;
        }

        private void Guna2ButtonSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerProp customerProp = new CustomerProp();
                customerProp.FirstName = guna2TextBoxEditFirstname.Text;
                customerProp.LastName = guna2TextBoxEditLastname.Text;
                customerProp.CustomerID = guna2TextBoxID.Text;

                CustomerClass customer = new CustomerClass();
                customer.SaveEdit(customerProp);

                MessageBox.Show("Data updated successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomerLoad();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Errro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guna2DataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = guna2DataGridViewCustomer.SelectedRows[0];
            guna2TextBoxEditFirstname.Text = selectedRow.Cells["FirstName"].Value.ToString();
            guna2TextBoxEditLastname.Text = selectedRow.Cells["LastName"].Value.ToString();
            guna2TextBoxID.Text = selectedRow.Cells["CustomerID"].Value.ToString();
        }
    }
}

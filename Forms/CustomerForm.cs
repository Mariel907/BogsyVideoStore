using Guna.UI2.WinForms;
using Project.Class;
using Project.Forms.ExtensionForms;
using Project.Model;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class CustomerForm : Form
    {
        private SearchCustomer search = new SearchCustomer();
        private string txbx;

        public CustomerForm()
        {
            InitializeComponent();
        }
        private void BtnNaming(object sender)
        {
            if (sender is Guna2Button button)
            {
                guna2ButtonAdd.Name = "Add";
                guna2ButtonEdit.Name = "Edit";

                ColorChanging(button.Name);
            }
        }

        private void ColorChanging(string ActiveButton)
        {
            Color ActiveColor = Color.FromArgb(0, 50, 73);
            Color InActiveColor = Color.FromArgb(0, 138, 162);

            guna2ButtonAdd.FillColor = ActiveButton == "Add" ? ActiveColor : InActiveColor;
            guna2ButtonEdit.FillColor = ActiveButton == "Edit" ? ActiveColor : InActiveColor;
        }
        private void Guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
            panelEdit.Visible = true;
            BtnNaming(sender);
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
            txbx = guna2TextBoxCustomer.Text;
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
            BtnNaming(sender);
        }

        private void Guna2ButtonSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
                txbx = guna2TextBoxCustomer.Text;

                CustomerProp customerProp = new CustomerProp();
                customerProp.FirstName = guna2TextBoxEditFirstname.Text;
                customerProp.LastName = guna2TextBoxEditLastname.Text;
                customerProp.CustomerID = guna2TextBoxID.Text;

                CustomerClass customer = new CustomerClass();
                customer.SaveEdit(customerProp);

                MessageBox.Show("Data updated successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                if (!string.IsNullOrEmpty(txbx))
                {
                    search.SearchTxbxCustomer(txbx, guna2DataGridViewCustomer);
                }
                else
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

        private void panelEdit_Paint(object sender, PaintEventArgs e)
        {
             
        }
    }
}

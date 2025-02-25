using CustomizeButtons;
using Project.Class;
using Project.Forms.ExtensionForms;
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

namespace Project.Forms
{
    public partial class CustomerForm : Form
    {
        Dashboard _dashboard;
        FormManager form = new FormManager();

        public CustomerForm(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
        }

        private void Guna2ButtonApproved_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            form.OpenForm(add, _dashboard.Panel);
        }

        private void Guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            CustomerProp customerProp = new CustomerProp();
            DataGridViewRow selectedRow = guna2DataGridViewCustomer.SelectedRows[0];

            customerProp.CustomerID = selectedRow.Cells["CustomerID"].Value.ToString();
            customerProp.FirstName = selectedRow.Cells["FirstName"].Value.ToString();
            customerProp.LastName = selectedRow.Cells["LastName"].Value.ToString();

            EditCustomer Edit = new EditCustomer(customerProp);
            FormManager form = new FormManager();
            form.OpenForm(Edit, _dashboard.Panel);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            HiddenColumn hiddenColumn = new HiddenColumn();
            hiddenColumn.GetAllCustomer(guna2DataGridViewCustomer);
        }

        private void CustomerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

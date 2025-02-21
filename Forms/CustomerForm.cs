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
        Dashboard dashboard;
        FormManager form = new FormManager();

        public CustomerForm(Dashboard dsahboard)
        {
            InitializeComponent();
            this.dashboard = dsahboard;
        }

        private void guna2ButtonApproved_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            form.OpenForm(signUp, dashboard.Panel);
        }

        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            CustomerProp customerProp = new CustomerProp();
            CustomerClass customer = new CustomerClass(dashboard);
            customer.FetchCustomerData(customerProp, guna2DataGridViewCustomer);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            HiddenColumn hiddenColumn = new HiddenColumn();
            hiddenColumn.GetAllCustomer(guna2DataGridViewCustomer);
        }

        private void guna2ButtonRent_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2ButtonRent_Click_1(object sender, EventArgs e)
        {
            CustomerProp customerProp = new CustomerProp();
            CustomerClass customer = new CustomerClass(dashboard);
            customer.FetchCustomerData(customerProp, guna2DataGridViewCustomer);
        }

        private void guna2DataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

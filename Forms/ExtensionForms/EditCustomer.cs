using Project.Class;
using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project.Forms.ExtensionForms
{
    public partial class EditCustomer : Form
    {
        private Dashboard dashboard;
        public EditCustomer(Dashboard dashboard, CustomerProp customerProp)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            guna2TextBoxFirstname.Text = customerProp.FirstName;
            guna2TextBoxLastName.Text = customerProp.LastName;
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void guna2ButtonSave_Click(object sender, EventArgs e)
        {
            CustomerProp customerProp = new CustomerProp();
            customerProp.FirstName = guna2TextBoxFirstname.Text;
            customerProp.LastName = guna2TextBoxLastName.Text;

            CustomerClass customer = new CustomerClass(dashboard);
            customer.SaveEdit(customerProp);
        }
    }
}

using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class EditCustomer : Form
    {
        public EditCustomer(Dashboard dashboard, CustomerProp customerProp)
        {
            InitializeComponent();
            guna2TextBoxFirstname.Text = customerProp.FirstName;
            guna2TextBoxLastName.Text = customerProp.LastName;
            guna2TextBoxAddress.Text = customerProp.Address;
            guna2TextBoxEmailAddress.Text = customerProp.Email;
            guna2TextBoxAge.Text = customerProp.Age;
            guna2TextBoxPhoneNumber.Text = customerProp.ContactNmbr;
        }

        private void label1_Click(object sender, EventArgs e)
        {
             
        }
    }
}

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
    public partial class AddCustomer : Form
    {
        private Dashboard _dashboard;
        public AddCustomer(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void guna2ButtonSave_Click(object sender, EventArgs e)
        { 
            CustomerProp customerprop = new CustomerProp();
            customerprop.FirstName = guna2TextBoxFirstname.Text;
            customerprop.LastName = guna2TextBoxLastName.Text;

            AddCstumer add = new AddCstumer();
            add.InsertCustomer(customerprop);
        }

        private void AddCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

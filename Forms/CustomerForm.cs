using Project.Class;
using Project.Forms.ExtensionForms;
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
            EditCustomer edit = new EditCustomer();
            form.OpenForm(edit, dashboard.Panel);
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            HiddenColumn hiddenColumn = new HiddenColumn();
            hiddenColumn.GetAllCustomer(guna2DataGridViewCustomer);
        }
    }
}

using Microsoft.Reporting.WinForms;
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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class TransSelectCustomer : Form
    {
        private StepByStepRent step;
        public TransSelectCustomer(StepByStepRent step)
        {
            InitializeComponent();
            this.step = step;
          
        }

        private void TransSelectCustomer_Load(object sender, EventArgs e)
        {
            this.getAllCustomerTableAdapter.Fill(this.dSReports.GetAllCustomer);
        }

        private void guna2TextBoxCustomer_TextChanged(object sender, EventArgs e)
        {
            string txbx = guna2TextBoxCustomer.Text;
            SearchCustomer search = new SearchCustomer();

            txbx = guna2TextBoxCustomer.Text;
            search.SearchTxbxCustomer(txbx, G2DGVCustomer);
        }

        private void GBtnNext_Click(object sender, EventArgs e)
        {
            Customers customerProp = new Customers();
            DataGridViewRow selectedRow = G2DGVCustomer.SelectedRows[0];
            customerProp.Fullname = $"{selectedRow.Cells["FirstName"].Value.ToString()} { selectedRow.Cells["LastName"].Value.ToString()}";
            customerProp.CustomerID = selectedRow.Cells["CustomerID"].Value.ToString(); 
            ChangeColor();

            RentCustomer rent = new RentCustomer(customerProp);
            FormManager form = new FormManager();
            form.OpenForm(rent, step.StepByStepPanel);
        }
        private void ChangeColor()
        {
            step.BookBtn.FillColor = Color.FromArgb(0, 50, 73);
            step.CustomerBtn.FillColor = Color.FromArgb(0, 138, 162);
        }
    }
}

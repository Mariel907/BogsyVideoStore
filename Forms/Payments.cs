using Project.Class;
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
    public partial class Payments: Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            HiddenColumn hide = new HiddenColumn();
            hide.Unpaid(DGVUnpaid);

            var Client = CPayments.ShowcmbUnpaid();
            guna2ComboBoxCustomerName.DataSource = Client;
            guna2ComboBoxCustomerName.DisplayMember = "Fullname";
            guna2ComboBoxCustomerName.ValueMember = "CustomerID";

            DGVUnpaid.AutoGenerateColumns = true;

        }

        private void guna2Buttonreturn_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = DGVUnpaid.SelectedRows[0];
            //row.Cells[]
        }

        private void guna2ComboBoxCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = guna2ComboBoxCustomerName.Text;
            CPayments payments = new CPayments();
           var results = payments.SearchUnpaid(search);
            DGVUnpaid.DataSource = results;
        }
    }
}

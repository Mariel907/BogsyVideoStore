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

namespace Project.Forms
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            HiddenColumn hide = new HiddenColumn();
            hide.GetAllRental(guna2DataGridViewTransaction);

        }

        private void guna2Buttonreturn_Click(object sender, EventArgs e)
        {
            Transac transac = new Transac();
            DataGridViewRow selectedRow = guna2DataGridViewTransaction.SelectedRows[0];
            transac.VideoID = selectedRow.Cells["VideoID"].Value?.ToString();
            transac.RentalId = selectedRow.Cells["RentalID"].Value?.ToString();

            Trans trans = new Trans();
            trans.Return(transac);
        }

        private void Transaction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

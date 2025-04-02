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
    public partial class ItemLedger : Form
    {
        public ItemLedger()
        {
            InitializeComponent();
        }

        private void ItemLedger_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSReports.GetAllItemLedger' table. You can move, or remove it, as needed.
            this.getAllItemLedgerTableAdapter.Fill(this.dSReports.GetAllItemLedger);

        }
    }
}

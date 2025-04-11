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
    public partial class ItemLedger : Form
    {
        public ItemLedger()
        {
            InitializeComponent();
        }

        private void ItemLedger_Load(object sender, EventArgs e)
        {
            DTPEndDate.Value = DateTime.Now.Date;
        }

        private void guna2ComboBoxReturned_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            CItemLedger search = new CItemLedger();
            string cmbx = G2CmbxLedger.Text;
            string txbx = G2TxbxLedger.Text;
            string cmbxType = G2CmbxType.Text;
            string DateEnd = DTPEndDate.Text;
            string DateStart = DTPStartDate.Text;
            search.SearchDVDTxbxItemLedger(txbx, cmbx, G2DGVItemLedger, cmbxType, DateEnd, DateStart);
        }

        private void G2TxbxLedger_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void G2CmbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void DTPEndDate_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void DTPStartDate_ValueChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}

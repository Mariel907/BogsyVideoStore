using Guna.UI2.WinForms;
using Project.Class;
using Project.Model;
using System;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class FReturn : Form
    {
        private Transaction _transaction;
        private Dashboard dashboard = new Dashboard();
        Trans trans = new Trans();
        private MSearchFieldRented _mSearchField;
        public FReturn(MSearchFieldRented mSearchField, Transaction transaction)
        {
            InitializeComponent();
            _transaction = new Transaction(dashboard);
            _mSearchField = mSearchField;
            _transaction = transaction;
        }

        private void FReturn_Load(object sender, EventArgs e)
        {
            DisplaySerialNo();
            CmbxSerialNo.Text = _mSearchField.cmbxSerialNo;
        }

        private void G2TxbxCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplaySerialNo()
        {
            var SearchSerial = Trans.SearchSerialReturn();
            CmbxSerialNo.DataSource = SearchSerial;
            CmbxSerialNo.DisplayMember = "SerialNo";
            CmbxSerialNo.ValueMember = "RentalID";
        }
        private void CmbxSerialNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbxSerialNo.SelectedValue != null)
            {
                SrchSerial sr = CmbxSerialNo.SelectedItem as SrchSerial;
                LblVideoID.Text = sr.VideoID.ToString();
                LblRentalID.Text = sr.RentalID.ToString();
                G2TxbxCustomerName.Text = sr.Fullname;
                G2TxbxCategory.Text = sr.Category;
                G2TxbxTitle.Text = sr.Title;
                LblSerialID.Text = sr.SerialID.ToString();
            }

        }

        private void guna2Buttonreturn_Click(object sender, EventArgs e)
        {
            try
            {
                Trans trans = new Trans();
                MTransac transac = new MTransac();
                transac.VideoID = LblVideoID.Text;
                transac.RentalId = LblRentalID.Text;
                transac.SerialNo = CmbxSerialNo.Text;
                transac.SerialID = Convert.ToInt32(LblSerialID.Text);

                trans.Return(transac);

                MessageBox.Show("Data Returned Successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplaySerialNo();
            RefreshFields();
            RentedReturnedShowButton();
        }
         
        private void RefreshFields()
        {
            LblVideoID.Text = string.Empty;
            LblRentalID.Text = string.Empty;
            CmbxSerialNo.Text = string.Empty;
            LblSerialID.Text = string.Empty;
            G2TxbxCategory.Text = string.Empty;
            G2TxbxCustomerName.Text = string.Empty;
            G2TxbxTitle.Text = string.Empty;    
        }
        private void RentedReturnedShowButton()
        {
            string cmbx = _transaction.CmbxSearch;
            string txbx = _transaction.TxbxSearch;
            string Edate = _transaction.EDateSearch;
            string Sdate = _transaction.SDateSearch;
            Guna2DataGridView DGV = _transaction.DGVRented;


            trans.RefreshSearchCMBXTxbxRented(Sdate, Edate, cmbx, txbx, DGV);
        }
        private void LblClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

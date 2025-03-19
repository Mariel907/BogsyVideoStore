using Project.Class;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class Payments : Form
    {
        private Rent rent = new Rent();
        private CPayments payments = new CPayments();

        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            this.unpaidTableAdapter.Fill(this.dSReports.Unpaid);

            DisplayCustomer();
            DisplayUnpaid();
        }
        private void DisplayCustomer()
        {
            var Client = CPayments.ShowcmbCustomer();
            comboBoxFullname.DisplayMember = "Fullname";
            comboBoxFullname.ValueMember = "CustomerID";
            comboBoxFullname.DataSource = Client;

        }

        private void DisplayUnpaid()
        {
            var Unpaid = CPayments.SearchUnpaid(guna2TextBoxCustomerID.Text);
            guna2ComboBoxVideoUnpaid.DataSource = Unpaid;
            guna2ComboBoxVideoUnpaid.DisplayMember = "Title";
            guna2ComboBoxVideoUnpaid.ValueMember = "VideoID";

        }

        private void guna2ButtonGntrReceipt_Click(object sender, EventArgs e)
        {
            if (guna2TextBoxCustomerID == null)
            {
                MessageBox.Show("Customer does not exist in the data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                payments.Confirmation(DGVUnpaid);
                try
                {
                    string Cash = guna2TextBoxCash.Text;
                    string Change = guna2TextBoxChange.Text;
                    string fullname = comboBoxFullname.Text;
                    payments.StoreRDLC(DGVUnpaid,Cash, Change, this.reportViewerPayment, fullname );

                    payments.Closed(DGVUnpaid);

                    DisplayCustomer();
                    DisplayUnpaid();
                    DGVUnpaid.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
       
        private void guna2TextBoxCash_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string totalAmountText = labelTotal.Text.Replace("P", "").Trim();
                    decimal totalAmount;
                    if (!decimal.TryParse(totalAmountText, out totalAmount))
                    {
                        MessageBox.Show("Invalid total amount format.");
                        return;
                    }
                    string _cash = guna2TextBoxCash.Text;
                    string Change = string.Empty;

                    rent.CalculateChange(totalAmount, _cash, ref Change);

                    guna2TextBoxChange.Text = Change;

                    e.SuppressKeyPress = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2ComboBoxTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBoxVideoUnpaid.SelectedValue != null)
            {
                SearchUnpaid search = guna2ComboBoxVideoUnpaid.SelectedItem as SearchUnpaid;
                guna2TextBoxPenalty.Text = search.Penalty;
                guna2TextBoxRentalID.Text = search.RentalID;
            }
        }

        private void comboBoxFullname_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxFullname.SelectedValue != null)
            {
                SearchUnpaid searchUnpaid = comboBoxFullname.SelectedItem as SearchUnpaid;
                guna2TextBoxCustomerID.Text = searchUnpaid.CustomerID;
            }
            DisplayUnpaid();
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            SearchUnpaid penalty = guna2ComboBoxVideoUnpaid.SelectedItem as SearchUnpaid;
            try
            {
                if (penalty != null)
                {
                    if (DGVUnpaid.Rows.Count > 0)
                    {
                        string existingCustomerID = DGVUnpaid.Rows[0].Cells["CustomerID"].Value.ToString();

                        if (existingCustomerID != penalty.CustomerID)
                        {
                            MessageBox.Show("You can only add items for the same customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; 
                        }
                    }
                    int rowIndex = DGVUnpaid.Rows.Add();
                    DataGridViewRow row = DGVUnpaid.Rows[rowIndex];
                    row.Cells["RentalID"].Value = penalty.RentalID;
                    row.Cells["Fullname"].Value = penalty.Fullname;
                    row.Cells["Quantity"].Value = penalty.Qty;
                    row.Cells["Title"].Value = penalty.Title;
                    row.Cells["Category"].Value = penalty.Category;
                    row.Cells["Penalty"].Value = penalty.Penalty;
                    row.Cells["CustomerID"].Value = penalty.CustomerID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DisplayUnpaid();
            string label = string.Empty;
            payments.UpdateTotal(DGVUnpaid, ref label);
            labelTotal.Text = label;
        }

        private void guna2TextBoxCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void guna2ButtonRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DGVUnpaid.Rows)
            {
                DGVUnpaid.Rows.RemoveAt(row.Index);
            }
        }

        private void comboBoxFullname_TextChanged(object sender, EventArgs e)
        {
            guna2TextBoxCustomerID.Text = string.Empty;
            guna2ComboBoxVideoUnpaid.DataSource = new List<string>();
            guna2ComboBoxVideoUnpaid.Text = string.Empty;
            guna2TextBoxPenalty.Text = string.Empty;
            guna2TextBoxRentalID.Text = string.Empty;   
        }
    }
}

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
            try
            {
                var list = new List<PenaltyReceipt>();
                foreach (DataGridViewRow row in DGVUnpaid.Rows)
                {
                    var penalty = new PenaltyReceipt();
                    penalty.RentalID = row.Cells["RentalID"].Value.ToString();
                    penalty.Fullname = row.Cells["Fullname"].Value.ToString();
                    penalty.Qty = row.Cells["Quantity"].Value.ToString();
                    penalty.Title = row.Cells["Title"].Value.ToString();
                    penalty.Category = row.Cells["Category"].Value.ToString();
                    penalty.Penalty = Convert.ToDecimal(row.Cells["Penalty"].Value);

                    list.Add(penalty);
                }

                ReceiptRDLC(list);

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

        private void ReceiptRDLC(List<PenaltyReceipt> list)
        {
            PenaltyReceipt penalty = new PenaltyReceipt
            {
                Cash = Convert.ToInt32(guna2TextBoxCash.Text),
                Change = Convert.ToDecimal(guna2TextBoxChange.Text)
            };

            PenaltyReceiptGenerator reportGenerator = new PenaltyReceiptGenerator(this.reportViewerPayment);
            reportGenerator.GeneratePaymentReceipt(penalty, comboBoxFullname.Text, list);
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

        private void LabelTotal_Click(object sender, EventArgs e)
        {

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
            CPayments.SearchUnpaid(guna2TextBoxCustomerID.Text);
            DisplayUnpaid();
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            SearchUnpaid penalty = guna2ComboBoxVideoUnpaid.SelectedItem as SearchUnpaid;
            try
            {
                if (penalty != null)
                {
                    int rowIndex = DGVUnpaid.Rows.Add();
                    DataGridViewRow row = DGVUnpaid.Rows[rowIndex];
                    row.Cells["RentalID"].Value = penalty.RentalID;
                    row.Cells["Fullname"].Value = penalty.Fullname;
                    row.Cells["Quantity"].Value = penalty.Qty;
                    row.Cells["Title"].Value = penalty.Title;
                    row.Cells["Category"].Value = penalty.Category;
                    row.Cells["Penalty"].Value = penalty.Penalty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string label = string.Empty;
            payments.UpdateTotal(DGVUnpaid, ref label);
            labelTotal.Text = label;

        }
    }
}

using Project.Class;
using Project.Model;
using System;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class RentCustomer : Form
    {
        private Rent rent = new Rent();
        public RentCustomer()
        {
            InitializeComponent();
        }
        private void guna2ButtonRent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guna2TextBoxCash.Text) && !string.IsNullOrEmpty(guna2TextBoxChange.Text))
            {
                Customers customerProp = new Customers();
                customerProp.CustomerID = guna2TextBoxCustomerID.Text;
                customerProp.Fullname = comboBoxFullname.Text;
                customerProp.Cash = Convert.ToInt32(guna2TextBoxCash.Text);
                customerProp.Change = Convert.ToDecimal(guna2TextBoxChange.Text);
                customerProp.CustomerID = guna2TextBoxCustomerID.Text;

                try
                {
                    rent._InsertRent(customerProp, DGVRent);
                    rent.AddReceiptModel(this.reportViewerRent, customerProp, DGVRent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClearFields();
            }
            else
                MessageBox.Show("Invalid Cash/Change input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ClearFields()
        {
            guna2TextBoxCash.Text = string.Empty;
            guna2TextBoxChange.Text = string.Empty;
            labelTotal.Text = string.Empty;
            DGVRent.Rows.Clear();
        }

        private void RentCustomer_Load(object sender, EventArgs e)
        {
            DisplayVideo();
            var customers = Rent.Fullname();
            comboBoxFullname.DataSource = customers;
            comboBoxFullname.DisplayMember = "Fullname";
            comboBoxFullname.ValueMember = "CustomerID";

            //this.reportViewerRent.RefreshReport();
        }

        private void DisplayVideo()
        {
            var Title = Rent.Video();
            comboBoxVideo.DataSource = Title;
            comboBoxVideo.DisplayMember = "Title";
            comboBoxVideo.ValueMember = "VideoID";
        }

        private void RentCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            VideoProp selectedVideo = comboBoxVideo.SelectedItem as VideoProp;
            try
            {
                if (selectedVideo != null)
                {
                    bool videoExists = false;
                    foreach (DataGridViewRow row in DGVRent.Rows)
                    {
                        if (row.Cells["VideoID"].Value.ToString() == selectedVideo.VideoId.ToString() && row.Cells["Status"].Value.ToString() != "Void")
                        {
                            int currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            row.Cells["Quantity"].Value = currentQuantity + 1;
                            row.Cells["Price"].Value = selectedVideo.Price;
                            row.Cells["TotalAmount"].Value = (currentQuantity + 1) * selectedVideo.Price;

                            rent.checkedOut(DGVRent, selectedVideo);
                            videoExists = true;
                            break;
                        }
                    }

                    if (!videoExists)
                    {
                        int rowIndex = DGVRent.Rows.Add();
                        DataGridViewRow row = DGVRent.Rows[rowIndex];
                        row.Cells["Title"].Value = selectedVideo.Title;
                        row.Cells["VideoID"].Value=selectedVideo.VideoId ;
                        row.Cells["LimitDaysRented"].Value = selectedVideo.LimitDaysRented;
                        row.Cells["Quantity"].Value = 1;
                        row.Cells["Price"].Value = selectedVideo.Price;
                        row.Cells["TotalAmount"].Value = selectedVideo.Price;
                        row.Cells["Category"].Value = selectedVideo.Category;
                        row.Cells["Status"].Value = "Checked Out";

                        int rentedDays = selectedVideo.LimitDaysRented;
                        row.Cells["DueDate"].Value = DateTime.Now.Date.AddDays(rentedDays).ToString("MM/dd/yyyy");
                        rent.checkedOut(DGVRent, selectedVideo);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string UpdateTotal = string.Empty;
            rent.UpdateTotal(DGVRent, ref UpdateTotal);
            labelTotal.Text = UpdateTotal;

            DisplayVideo();
        }

        private void TxtbxCash_KeyDown(object sender, KeyEventArgs e)
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
                decimal cash = Convert.ToDecimal(guna2TextBoxCash.Text);
                string Change = string.Empty;

                rent.CalculateChange(totalAmount, cash, ref Change);

                guna2TextBoxChange.Text = Change;

                e.SuppressKeyPress = true;
            }
        }

        private void guna2ButtonVoid_Click(object sender, EventArgs e)
        {
            try
            {
                string updateTotal = string.Empty;
                rent.Void(DGVRent, guna2TextBoxCustomerID.Text);
                bool hasError = rent.TotalAmountToSubtract(DGVRent, labelTotal.Text, ref updateTotal);

                if (!hasError)
                    MessageBox.Show("Please select a row to void", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                labelTotal.Text = updateTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayVideo();
        }

        private void comboBoxFullname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFullname.SelectedValue != null)
            {
                Customers customer = comboBoxFullname.SelectedItem as Customers;
                guna2TextBoxCustomerID.Text = customer.CustomerID;
            }
        }

        private void guna2TextBoxCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

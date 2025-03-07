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
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            DGVRent.Columns.Add("Title", "Title");
            DGVRent.Columns.Add("VideoID", "Video ID");
            DGVRent.Columns["VideoID"].Visible = false;
            DGVRent.Columns.Add("LimitDaysRented", "Limit Days Rented");
            DGVRent.Columns["LimitDaysRented"].Visible = false;
            DGVRent.Columns.Add("Quantity", "Quantity");
            DGVRent.Columns.Add("Price", "Price");
            DGVRent.Columns.Add("Category", "Category");
            DGVRent.Columns.Add("DueDate", "Due Date");
            DGVRent.Columns.Add("TotalAmount", "Total Amount");
            DGVRent.Columns.Add("Status", "Status");
            DGVRent.Columns["Status"].Visible = false;
        }

        private void guna2ButtonRent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(guna2TextBoxCash.Text) && !string.IsNullOrEmpty(guna2TextBoxChange.Text))
            {
                Customers customerProp = new Customers();
                customerProp.CustomerID = guna2TextBoxCustomerID.Text;
                customerProp.Fullname = guna2ComboBoxCustomer.Text;
                customerProp.Cash = Convert.ToInt32(guna2TextBoxCash.Text);
                customerProp.Change = Convert.ToDecimal(guna2TextBoxChange.Text.Replace("P","").Trim());

                Receipt receipt = rent._InsertRent(customerProp, DGVRent);
            }
            else
                MessageBox.Show("Invalid Cash/Change input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }

        private void RentCustomer_Load(object sender, EventArgs e)
        {
            var customers = Rent.Fullname();
            guna2ComboBoxCustomer.DataSource = customers;
            guna2ComboBoxCustomer.DisplayMember = "Fullname";
            guna2ComboBoxCustomer.ValueMember = "CustomerID";

            var Title = Rent.Video();
            guna2ComboBoxVideo.DataSource = Title;
            guna2ComboBoxVideo.DisplayMember = "Title";
            guna2ComboBoxVideo.ValueMember = "VideoID";
        }

        private void RentCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            VideoProp selectedVideo = guna2ComboBoxVideo.SelectedItem as VideoProp;
            try
            {
                if (selectedVideo != null)
                {
                    bool videoExists = false;
                    foreach (DataGridViewRow row in DGVRent.Rows)
                    {
                        if (row.Cells["VideoID"].Value.ToString() == selectedVideo.VideoId.ToString())
                        {
                            int currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            row.Cells["Quantity"].Value = currentQuantity + 1;
                            row.Cells["Price"].Value = selectedVideo.Price;
                            row.Cells["TotalAmount"].Value = (currentQuantity + 1) * selectedVideo.Price;
                            videoExists = true;
                            break;
                        }
                    }

                    if (!videoExists)
                    {
                        int rowIndex = DGVRent.Rows.Add();
                        DataGridViewRow row = DGVRent.Rows[rowIndex];
                        row.Cells["Title"].Value = selectedVideo.Title;
                        row.Cells["VideoID"].Value = selectedVideo.VideoId;
                        row.Cells["LimitDaysRented"].Value = selectedVideo.LimitDaysRented;
                        row.Cells["Quantity"].Value = 1;
                        row.Cells["Price"].Value = selectedVideo.Price;
                        row.Cells["TotalAmount"].Value = selectedVideo.Price;
                        row.Cells["Category"].Value = selectedVideo.Category;
                        row.Cells["Status"].Value = "Checked Out";

                        int rentedDays = selectedVideo.LimitDaysRented;
                        row.Cells["DueDate"].Value = DateTime.Now.Date.AddDays(rentedDays).ToString("yyyy-MM-dd");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in DGVRent.Rows)
            {
                if (row.Cells["TotalAmount"].Value != null)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                }
            }
            labelTotal.Text = "P" + totalAmount.ToString("N2");
        }

        private void guna2ComboBoxCustomer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (guna2ComboBoxCustomer.SelectedValue != null)
            {
                Customers customer = guna2ComboBoxCustomer.SelectedItem as Customers;
                guna2TextBoxCustomerID.Text = customer.CustomerID;
            }
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
                string cash = guna2TextBoxCash.Text;
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
                if (DGVRent.SelectedRows.Count > 0)
                {
                    decimal TotalAmountToSubtract = 0;
                    foreach (DataGridViewRow row in DGVRent.SelectedRows)
                    {
                        row.Cells["Status"].Value = "Void";
                        TotalAmountToSubtract += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                    }
                    decimal updateLabel = Convert.ToDecimal(labelTotal.Text.Replace("P", "").ToString());
                   
                    UpdateTotalVoid(labelTotal.Text, ref updateLabel, TotalAmountToSubtract);

                    labelTotal.Text ="P" + updateLabel.ToString("N2");
                }
                else
                    MessageBox.Show("Please select a row to void.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateTotalVoid(string label, ref decimal updatelabel, decimal amountToSubtract)
        {
            updatelabel -= amountToSubtract;
            label = "P" + updatelabel.ToString("N2");
        }

        private void guna2ComboBoxVideo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

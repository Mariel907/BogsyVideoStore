using Project.Class;
using Project.Model;
using System;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class RentCustomer : Form
    {
        private Rent rent = new Rent();
        public DataGridView DgvRent { get { return DGVRent; } }
        public RentCustomer(Customers customer)
        {
            InitializeComponent();
            G2TxbxCustomer.Text = customer.Fullname;
            labelCustomerName.Text = customer.CustomerID;
        }
        private void Guna2ButtonRent_Click(object sender, EventArgs e)
        {
            if (HasInvalidInput()) return;

            var customer = CreateCustomer();

            try
            {
                rent._InsertRent(customer, DGVRent);
                rent.AddReceiptModel(reportViewerRent, customer, DGVRent);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplaySerial();
            DisplayVideo();
        }

        private bool HasInvalidInput()
        {
            if (string.IsNullOrEmpty(guna2TextBoxCash.Text) && string.IsNullOrEmpty(guna2TextBoxChange.Text))
            {
                MessageBox.Show("Invalid Cash/Change input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        public Customers CreateCustomer()
        {
            return new Customers
            {
                CustomerID = labelCustomerName.Text,
                Fullname = G2TxbxCustomer.Text,
                Cash = Convert.ToDecimal(guna2TextBoxCash.Text),
                Change = Convert.ToDecimal(guna2TextBoxChange.Text),
            };
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
            DisplaySerial();
            //var customers = Rent.Fullname();
            //comboBoxFullname.DataSource = customers;
            //comboBoxFullname.DisplayMember = "Fullname";
            //comboBoxFullname.ValueMember = "CustomerID";
        }

        private void DisplayVideo()
        {
            var Title = Rent.Video();
            comboBoxVideo.DataSource = Title;
            comboBoxVideo.DisplayMember = "Title";
            comboBoxVideo.ValueMember = "VideoID";
        }

        private void DisplaySerial()
        {
            var serial = Rent.SearchSerial(LblTitle.Text);
            CmbxSerialNo.DataSource = serial;
            CmbxSerialNo.DisplayMember = "SerialNo";
            CmbxSerialNo.ValueMember = "SerialID";
        }
        private void RentCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            VideoProp selectedVideo = comboBoxVideo.SelectedItem as VideoProp;
            SrchSerial selectedSerial = CmbxSerialNo.SelectedItem as SrchSerial;
            try
            {
                if (selectedVideo != null)
                {
                    //bool videoExists = false;
                    //foreach (DataGridViewRow row in DGVRent.Rows)
                    //{
                    //    if (row.Cells["VideoID"].Value.ToString() == selectedVideo.VideoId.ToString() && row.Cells["Status"].Value.ToString() != "Void")
                    //    {
                    //        int currentQuantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    //        row.Cells["Quantity"].Value = currentQuantity + 1;
                    //        row.Cells["Price"].Value = selectedVideo.Price;
                    //        row.Cells["TotalAmount"].Value = (currentQuantity + 1) * selectedVideo.Price;

                    //        rent.CheckedOut(selectedVideo);
                    //        videoExists = true;
                    //        break;
                    //    }
                    //}

                    //if (!videoExists)
                    //{

                    int rowIndex = DGVRent.Rows.Add();
                    DataGridViewRow row = DGVRent.Rows[rowIndex];
                    row.Cells["Title"].Value = selectedVideo.Title;
                    row.Cells["VideoID"].Value = selectedVideo.VideoId;
                    row.Cells["LimitDaysRented"].Value = selectedVideo.LimitDaysRented;
                    row.Cells["Quantity"].Value = 1;
                    row.Cells["Price"].Value = selectedVideo.Price;
                    //row.Cells["TotalAmount"].Value = selectedVideo.Price;
                    row.Cells["Category"].Value = selectedVideo.Category;
                    row.Cells["Status"].Value = "Checked Out";
                    row.Cells["SerialNo"].Value = selectedSerial.SerialNo;
                    row.Cells["SerialID"].Value = selectedSerial.SerialID;

                    int rentedDays = selectedVideo.LimitDaysRented;
                    row.Cells["DueDate"].Value = DateTime.Now.Date.AddDays(rentedDays).ToString("MM/dd/yyyy");
                    rent.CheckedOut (selectedSerial, selectedVideo);

                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string UpdateTotal = string.Empty;
            rent.UpdateTotal(DGVRent, ref UpdateTotal);
            labelTotal.Text = UpdateTotal;

            DisplaySerial();
            DisplayVideo();
        }

        private void TxtbxCash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            if (!decimal.TryParse(labelTotal.Text.Replace("P", "").Trim(), out decimal totalAmount))
            {
                MessageBox.Show("Invalid total amount format.");
                return;
            }
            decimal cash = Convert.ToDecimal(guna2TextBoxCash.Text);
            string Change = string.Empty;

            rent.CalculateChange(totalAmount, Convert.ToDecimal(guna2TextBoxCash.Text), ref Change);

            guna2TextBoxCash.Text = cash.ToString("N2");
            guna2TextBoxChange.Text = Change;
            e.SuppressKeyPress = true;
        }

        private void Guna2ButtonVoid_Click(object sender, EventArgs e)
        {
            try
            {
                string updateTotal = string.Empty;
                rent.Void(DGVRent, labelCustomerName.Text);
                rent.SubtractTotalAmount(DGVRent, labelTotal.Text, ref updateTotal);

                labelTotal.Text = updateTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DisplayVideo();
        }

        private void ComboBoxFullname_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBoxFullname.SelectedValue != null)
            //{
            //    Customers customer = comboBoxFullname.SelectedItem as Customers;
            //    labelCustomerName.Text = customer.CustomerID;
            //}
        }

        private void Guna2TextBoxCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void comboBoxVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbxSerialNo.Text = "";
            if (comboBoxVideo.SelectedValue != null)
            {
                VideoProp vd = comboBoxVideo.SelectedItem as VideoProp;
                LblTitle.Text = vd.VideoId.ToString();
            }
            DisplaySerial();
        }
    }
}

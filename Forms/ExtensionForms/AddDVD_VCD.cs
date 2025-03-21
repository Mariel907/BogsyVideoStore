using Project.Class;
using Project.Model;
using System;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class AddDVD_VCD : Form
    {

        public AddDVD_VCD()
        {
            InitializeComponent();
        }

        private void Guna2ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                VideoProp video = new VideoProp();
                video.Title = guna2TextBoxTitle.Text;
                video.CopiesAvailable = guna2TextBoxTotalCopies.Text;
                video.Category = guna2ComboBoxCategory.Text;
                video.LimitDaysRented = Convert.ToInt16(guna2ComboBoxLimitdaysRented.Text);

                VideoLibrary vd = new VideoLibrary();
                vd.Insert(video);
                MessageBox.Show("Data added successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddDVD_VCD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
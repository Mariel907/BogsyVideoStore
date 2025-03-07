using Project.Class;
using Project.Model;
using System;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class AddDVD_VCD : Form
    {
        public string Title { get { return guna2TextBoxTitle.Text; } set { guna2TextBoxTitle.Text = value; } }
        public string CopiesAvailable { get { return guna2TextBoxTotalCopies.Text; } set { guna2TextBoxTotalCopies.Text = value; } }
        public string Category { get { return guna2ComboBoxCategory.Text; }  set { guna2ComboBoxCategory.Text = value; } }

        public AddDVD_VCD()
        {
            InitializeComponent();
        }

        private void guna2ButtonSubmit_Click(object sender, EventArgs e)
        {
            VideoProp video = new VideoProp();
            video.Title = Title;
            video.CopiesAvailable = CopiesAvailable;
            video.Category = Category;
            video.LimitDaysRented = Convert.ToInt16(guna2ComboBoxLimitdaysRented.Text);

            VideoLibrary vd = new VideoLibrary();
            bool IsInserted = vd.Insert(video);

            if (IsInserted)
                MessageBox.Show("Data added successfully ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An error occured during inserting. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AddDVD_VCD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
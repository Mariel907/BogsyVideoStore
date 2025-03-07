using Project.Class;
using Project.Model;
using System;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class EditDVD_VCD : Form
    {
        private VideoProp _video;
        public EditDVD_VCD(VideoProp video)
        {
            InitializeComponent();
            _video = video;
            //guna2TextBoxTitle.Text = _video.Title;
            //guna2TextBoxCopiesAvailable.Text = _video.CopiesAvailable;
            //guna2ComboBoxCategory.Text = _video.Category;

            //guna2TextBoxVideoID.Text = _video.VideoId;
        }

        private void guna2ButtonSubmit_Click(object sender, EventArgs e)
        {
            VideoProp video = new VideoProp();
            video.Title = guna2TextBoxTitle.Text;
            video.CopiesAvailable = guna2TextBoxCopiesAvailable.Text;
            video.Category = guna2ComboBoxCategory.Text;
            video.VideoId = Convert.ToInt16(guna2TextBoxVideoID.Text);

            Class.VideoLibrary vd = new Class.VideoLibrary();
            bool isUpdated = vd.Update(video);

            if (isUpdated) 
                MessageBox.Show("Data updated successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("An error occured during updating. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EditDVD_VCD_Load(object sender, EventArgs e)
        {
            HiddenColumn hide = new HiddenColumn();
        }

        private void EditDVD_VCD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

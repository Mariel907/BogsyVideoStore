 using Project.Class;
using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class EditDVD_VCD : Form
    {
        private Dashboard dashboard;
        private VideoLibrary _video;
        public EditDVD_VCD(Dashboard dashboard, VideoLibrary video)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            _video = video;
            guna2TextBoxTitle.Text = _video.Title;
            guna2TextBoxCopiesAvailable.Text = _video.CopiesAvailable;
            guna2ComboBoxCategory.Text = _video.Category;
            guna2TextBoxVideoID.Text = _video.VideoId;
        }

        private void guna2ButtonSubmit_Click(object sender, EventArgs e)
        {
            VideoLibrary video = new VideoLibrary();
            video.Title = guna2TextBoxTitle.Text;
            video.CopiesAvailable = guna2TextBoxCopiesAvailable.Text;
            video.Category = guna2ComboBoxCategory.Text;
            video.VideoId = guna2TextBoxVideoID.Text;

            Video vd = new Video(dashboard);
            vd.Update(video);
        }

        private void labelBook_Click(object sender, EventArgs e)
        {

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

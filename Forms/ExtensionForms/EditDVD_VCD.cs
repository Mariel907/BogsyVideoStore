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
        public EditDVD_VCD(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void guna2ButtonSubmit_Click(object sender, EventArgs e)
        {
            VideoLibrary video = new VideoLibrary();
            video.Title = guna2TextBoxTitle.Text;
            video.CopiesAvailable = guna2TextBoxCopiesAvailable.Text;
            video.Category = guna2ComboBoxCategory.Text;

            Video vd = new Video(dashboard);
            vd.Insert(video);
        }
    }
}

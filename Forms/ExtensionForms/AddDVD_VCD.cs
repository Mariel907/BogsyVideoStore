using Guna.UI2.WinForms;
using Project.Class;
using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project.Forms.ExtensionForms
{
    public partial class AddDVD_VCD : Form
    {
        private Dashboard dashboard;
        bool hasError = false;
        public string Title { get { return guna2TextBoxTitle.Text; } set { guna2TextBoxTitle.Text = value; } }
        public string CopiesAvailable { get { return guna2TextBoxTotalCopies.Text; } set { guna2TextBoxTotalCopies.Text = value; } }
        public string Category { get { return guna2ComboBoxCategory.Text; }  set { guna2ComboBoxCategory.Text = value; } }

        public AddDVD_VCD(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void guna2ButtonSubmit_Click(object sender, EventArgs e)
        {
            VideoLibrary video = new VideoLibrary();
            video.Title = Title;
            video.CopiesAvailable = CopiesAvailable;
            video.Category = Category;

            if (hasError)
                return;

            Video vd = new Video(dashboard);
            hasError |= vd.Insert(video);
           
            
            if(hasError)
            {
                MessageBox.Show("Data added successfully ", "SuccessFul", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2TextBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
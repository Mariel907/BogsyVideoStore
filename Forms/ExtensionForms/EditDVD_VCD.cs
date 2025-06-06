﻿using Project.Class;
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
            guna2TextBoxTitle.Text = _video.Title;
            G2CmbxLimitDaysRented.Text = _video.LimitDaysRented.ToString();
            guna2ComboBoxCategory.Text = _video.Category;
            guna2TextBoxVideoID.Text = _video.VideoId.ToString();
        }

        private void guna2ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                VideoProp video = new VideoProp();
                video.Title = guna2TextBoxTitle.Text;
                video.LimitDaysRented = int.Parse(G2CmbxLimitDaysRented.Text);
                video.Category = guna2ComboBoxCategory.Text;
                video.VideoId = Convert.ToInt16(guna2TextBoxVideoID.Text);

                VideoLibrary vd = new VideoLibrary();
                vd.Update(video);
                MessageBox.Show("Video updated successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditDVD_VCD_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void GBtnAdd_Click_1(object sender, EventArgs e)
        {
            //AddDVD_VCD add = new AddDVD_VCD();
            //FormManager form = new FormManager();
            //form.OpenForm(add, panelEdit);
        }

        private void GBtnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void panelEdit_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

using Project.Class;
using Project.Forms.ExtensionForms;
using Project.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class DVDs_VCDs : Form
    {
        private Dashboard dashboard;
        private AddDVD_VCD add = new AddDVD_VCD();
        private SearchVideo search = new SearchVideo();
        public DVDs_VCDs(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void Guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            FormManager form = new FormManager();
            form.OpenForm(add, dashboard.Panel);
        }

        private void DVDs_VCDs_Load(object sender, EventArgs e)
        {
            GetAllVideo();

        }
        private void GetAllVideo()
        {
            this.getAllVideoTableAdapter.Fill(this.dSTransaction.GetAllVideo);
        }
      
        private void Guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            VideoProp video = new VideoProp();
            DataGridViewRow selectedRow = dgvVideo.SelectedRows[0];
            video.VideoId = Convert.ToInt32(selectedRow.Cells["VideoID"].Value.ToString());
            video.Title = selectedRow.Cells["Title"].Value.ToString();
            video.Category = selectedRow.Cells["Category"].Value.ToString();
            video.LimitDaysRented = int.Parse(selectedRow.Cells["LimitDaysRented"].Value.ToString());

            EditDVD_VCD Edit = new EditDVD_VCD(video);
            FormManager form = new FormManager();
            form.OpenForm(Edit, dashboard.Panel);
        }

        private void Guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                VideoLibrary vd = new VideoLibrary();
                VideoProp video = new VideoProp();

                DataGridViewRow selectedRow = dgvVideo.SelectedRows[0];

                video.VideoId = Convert.ToInt32(selectedRow.Cells["VideoID"].Value.ToString());

                var result = MessageBox.Show("Are you sure you want to delete this video.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    vd.Delete(video);
                    MessageBox.Show("video deleted successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    return;

                if(!string.IsNullOrEmpty(G2CmbxVideo.Text) || !string.IsNullOrEmpty(guna2TextBoxVideo.Text))
                    Search();
                else
                    GetAllVideo();
            }
            catch (SqlException ex)
            {
                if (ex.Class == 16)
                    MessageBox.Show("Oops! It looks like this video is currently rented, so we can't delete it right now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DVDs_VCDs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Guna2TextBoxDVD_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string txbx = guna2TextBoxVideo.Text;
            string cmbx = G2CmbxVideo.Text;
            search.SearchCmbxTxbx(txbx, cmbx, dgvVideo);
        }

        private void G2CmbxVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}

using Project.Class;
using Project.Forms.ExtensionForms;
using Project.Model;
using System;
using System.Data.SqlClient;
using System.Drawing;
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
            GetAllDVD();

        }
        private void GetAllDVD()
        {
            this.getAllDVDTableAdapter.Fill(this.dSReports.GetAllDVD);
            dgvVCD.Visible = false;
            dgvDVD.Visible = true;
            guna2TextBoxDVD.Visible = true;
            guna2TextBoxVCD.Visible = false;
        }
        private void GetAllVCD()
        {
            this.getAllVCDTableAdapter.Fill(this.dSReports.GetAllVCD);
            dgvVCD.Visible = true;
            dgvDVD.Visible = false;
            guna2TextBoxDVD.Visible = false;
            guna2TextBoxVCD.Visible = true;
        }
        private void Guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            VideoProp video = new VideoProp();
            if (dgvDVD.Visible)
            {
                DataGridViewRow selectedRow = dgvDVD.SelectedRows[0];
                video.VideoId = Convert.ToInt32(selectedRow.Cells["VideoID"].Value.ToString());
                video.Title = selectedRow.Cells["Title"].Value.ToString();
                video.Category = selectedRow.Cells["Category"].Value.ToString();
                video.LimitDaysRented = int.Parse(selectedRow.Cells["LimitDaysRented"].Value.ToString());
            }
            else
            {
                DataGridViewRow selectedRow = dgvVCD.SelectedRows[0];
                video.VideoId = Convert.ToInt32(selectedRow.Cells["VCDVideoID"].Value.ToString());
                video.Title = selectedRow.Cells["VCDTitle"].Value.ToString();
                video.Category = selectedRow.Cells["VCDCategory"].Value.ToString();
                video.LimitDaysRented = int.Parse(selectedRow.Cells["VCDLimitDaysRented"].Value.ToString());
            }

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

                DataGridViewRow selectedRow = dgvDVD.Visible
                    ? dgvDVD.SelectedRows[0]
                    : dgvVCD.SelectedRows[0];

                video.VideoId = dgvDVD.Visible
                    ? Convert.ToInt32(selectedRow.Cells["VideoID"].Value.ToString())
                    : Convert.ToInt32(selectedRow.Cells["VCDVideoID"].Value.ToString());

                var result = MessageBox.Show("Are you sure you want to delete this video.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    vd.Delete(video);
                    MessageBox.Show("video deleted successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    return;

                GetAllDVD();
            }
            catch (SqlException ex)
            {
                if (ex.Class == 16)
                    MessageBox.Show("Oops! It looks like this video is currently rented, so we can't delete it right now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Guna2ButtonDVD_Click(object sender, EventArgs e)
        {
            GetAllDVD();
            guna2ButtonDVD.FillColor = Color.FromArgb(0, 50, 73);
            guna2ButtonVCD.FillColor = Color.FromArgb(0, 138, 162);
        }

        private void Guna2ButtonVCD_Click(object sender, EventArgs e)
        {
            GetAllVCD();
            guna2ButtonDVD.FillColor = Color.FromArgb(0, 138, 162);
            guna2ButtonVCD.FillColor = Color.FromArgb(0, 50, 73);
        }

        private void DVDs_VCDs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Guna2TextBoxDVD_TextChanged(object sender, EventArgs e)
        {
            string txbx = guna2TextBoxDVD.Text;
            search.SearchTxbxDVD(txbx, dgvDVD);
        }

        private void Guna2TextBoxVCD_TextChanged(object sender, EventArgs e)
        {
            string txbx = guna2TextBoxVCD.Text;
            search.SearchTxbxVCD(txbx, dgvVCD);
        }
    }
}

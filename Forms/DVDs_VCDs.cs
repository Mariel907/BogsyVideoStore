using Project.Class;
using Project.Forms.ExtensionForms;
using Project.Model;
using System;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class DVDs_VCDs : Form
    {
        private Dashboard dashboard;
        private AddDVD_VCD add = new AddDVD_VCD();
        private HiddenColumn hiddenColumn = new HiddenColumn();

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
            hiddenColumn.GetAllDVD(dgvDVDs__VCDs);
        }

        private void Guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            Model.VideoProp video = new VideoProp();
            DataGridViewRow selectedRow = dgvDVDs__VCDs.SelectedRows[0];

            video.VideoId = Convert.ToInt32(selectedRow.Cells["VideoID"].Value.ToString());
            video.Title = selectedRow.Cells["Title"].Value.ToString();
            video.Category = selectedRow.Cells["Category"].Value.ToString();
            video.CopiesAvailable = selectedRow.Cells["CopiesAvailable"].Value.ToString();

            EditDVD_VCD Edit = new EditDVD_VCD(video);
            FormManager form = new FormManager();
            form.OpenForm(Edit, dashboard.Panel);
        }

        private void Guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            VideoLibrary vd = new VideoLibrary();
            VideoProp video = new VideoProp();
            DataGridViewRow selectedRow = dgvDVDs__VCDs.SelectedRows[0]; 
            video.VideoId = Convert.ToInt32(selectedRow.Cells["VideoID"].Value.ToString());

            bool IsDeleted = vd.Delete(video);

            if (IsDeleted)
                MessageBox.Show("video deleted successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Oops! It looks like this video is currently rented, so we can't delete it right now.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            hiddenColumn.GetAllDVD(dgvDVDs__VCDs);
        }

        private void Guna2ButtonDVD_Click(object sender, EventArgs e)
        {
            HiddenColumn hiddenColumn = new HiddenColumn();
            hiddenColumn.GetAllDVD(dgvDVDs__VCDs);
        }

        private void Guna2ButtonVCD_Click(object sender, EventArgs e)
        {
            HiddenColumn Hide = new HiddenColumn();
            Hide.GetAllVCD(dgvDVDs__VCDs);
        }

        private void DVDs_VCDs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

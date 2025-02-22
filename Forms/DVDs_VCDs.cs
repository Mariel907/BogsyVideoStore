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
        private AddDVD_VCD add;
        public DVDs_VCDs(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
            add = new AddDVD_VCD(dashboard);
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            FormManager form = new FormManager();

            form.OpenForm(add, dashboard.Panel);
        }

        private void DVDs_VCDs_Load(object sender, EventArgs e)
        {
            HiddenColumn hiddenColumn = new HiddenColumn();
            hiddenColumn.GetAllDVD(dgvDVDs__VCDs);
        }

        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            EditVideoLibrary Edit = new EditVideoLibrary(dashboard);
            Edit.FetchVideoLibrary(dgvDVDs__VCDs);
        }

        private void guna2ButtonDelete_Click(object sender, EventArgs e)
        {
            Video vd = new Video(dashboard);
            vd.FetchId(dgvDVDs__VCDs);
        }

        private void dgvDVDs__VCDs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            VideoLibrary video = new VideoLibrary();
            DataGridViewRow selectedRow = dgvDVDs__VCDs.SelectedRows[0];
            video.VideoId = selectedRow.Cells["VideoID"].Value.ToString();
        }

        private void guna2ButtonDVD_Click(object sender, EventArgs e)
        {
            HiddenColumn hiddenColumn = new HiddenColumn();
            hiddenColumn.GetAllDVD(dgvDVDs__VCDs);
        }

        private void guna2ButtonVCD_Click(object sender, EventArgs e)
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

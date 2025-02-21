using Project.Class;
using Project.Forms.ExtensionForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class DVDs_VCDs : Form
    {
        private Dashboard dashboard;
        public DVDs_VCDs(Dashboard dashboard)
        {
            InitializeComponent();
            this.dashboard = dashboard;
        }

        private void guna2ButtonAdd_Click(object sender, EventArgs e)
        {
            AddDVD_VCD add = new AddDVD_VCD();
            FormManager form = new FormManager();

            form.OpenForm(add, dashboard.Panel);
        }

        private void DVDs_VCDs_Load(object sender, EventArgs e)
        {
            HiddenColumn hide = new HiddenColumn();
            hide.GetAllVideo(dgvDVDs__VCDs);
        }

        private void guna2ButtonEdit_Click(object sender, EventArgs e)
        {
            EditVideoLibrary Edit = new EditVideoLibrary(dashboard);
            Edit.FetchVideoLibrary(dgvDVDs__VCDs);
        }
    }
}

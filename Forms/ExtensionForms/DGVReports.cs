using Project.Class;
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
    public partial class DGVReports : Form
    {
        public DGVReports()
        {
            InitializeComponent();
        }

        private void DGVReports_Load(object sender, EventArgs e)
        {
            DataLoader dataLoader = new DataLoader();
            dataLoader.Reports(guna2DataGridViewReports);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

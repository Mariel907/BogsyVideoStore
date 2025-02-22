using Project.Forms;
using Project.Forms.ExtensionForms;
using Project.Model;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Class
{
    public class EditVideoLibrary
    {
        private Dashboard dashboard;
        public EditVideoLibrary(Dashboard dashboard)
        {
            this.dashboard = dashboard;
        }
        public void FetchVideoLibrary(DataGridView dataGridView)
        {
            try
            {
                VideoLibrary video = new VideoLibrary();
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                video.VideoId = selectedRow.Cells["VideoID"].Value.ToString();
                video.Title = selectedRow.Cells["Title"].Value.ToString();
                video.Category = selectedRow.Cells["Category"].Value.ToString();
                video.CopiesAvailable = selectedRow.Cells["CopiesAvailable"].Value.ToString();

                EditDVD_VCD Edit = new EditDVD_VCD(dashboard, video);
                FormManager form = new FormManager();
                form.OpenForm(Edit, dashboard.Panel);
            }
            catch (SqlException m)
            {
                MessageBox.Show(m.ToString());
            }
        }
    }
}

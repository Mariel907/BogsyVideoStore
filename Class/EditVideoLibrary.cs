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

                video.VideoId = Convert.ToInt32(selectedRow.Cells["VideoID"].Value);
                video.Title = selectedRow.Cells["Title"].Value.ToString();
                video.Genre = selectedRow.Cells["Genre"].Value.ToString();
                video.Category = selectedRow.Cells["Category"].Value.ToString();
                video.SerialNumber = selectedRow.Cells["SerialNumber"].Value.ToString();
                video.Director = selectedRow.Cells["Director"].Value.ToString();
                video.Rating = selectedRow.Cells["Rating"].Value.ToString();
                video.ReleaseDate = Convert.ToDateTime(selectedRow.Cells["ReleaseDate"].Value);
                video.CopiesAvailable = selectedRow.Cells["CopiesAvailable"].Value.ToString();

                EditDVD_VCD Edit = new EditDVD_VCD(video);
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

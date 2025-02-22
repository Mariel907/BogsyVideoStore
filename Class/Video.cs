using Project.Forms;
using Project.Forms.ExtensionForms;
using Project.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Project.Class
{
    public class Video
    {
        private Dashboard dashboard;
        public Video(Dashboard dashboard)
        {
            this.dashboard = dashboard;
        }
        public void Update(VideoLibrary video)
        {

            using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateVideo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VideoID", video.VideoId);
                    cmd.Parameters.AddWithValue("@Title", video.Title);
                    cmd.Parameters.AddWithValue("@Category", video.Category);
                    cmd.Parameters.AddWithValue("@Out", video.CopiesAvailable);

                    if (video.Category == "DVD")
                    {
                        cmd.Parameters.AddWithValue("@Amount", 50);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Amount", 25);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool Insert(VideoLibrary video)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("InsertVideo", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Title", video.Title);
                        cmd.Parameters.AddWithValue("@Category", video.Category);
                        cmd.Parameters.AddWithValue("@In", video.CopiesAvailable);
                        cmd.Parameters.AddWithValue("@Out", video.CopiesAvailable);

                        if (video.Category == "DVD")
                        {
                            cmd.Parameters.AddWithValue("@Amount", 50);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Amount", 25);
                        }
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An eror occured during login");
            }
            return false;
        }
        public void InsertCustomer(CustomerProp Customer)
        {

            using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("InsertRent", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CustomerID", Customer.CustomerID);
                    cmd.Parameters.AddWithValue("@VideoID", Customer.VideoID);
                    cmd.Parameters.AddWithValue("@RentDate", DateTime.Now.Date);
                    cmd.Parameters.AddWithValue("@Duedate", DateTime.Now.AddDays(3).Date);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(DataGridView dataGridView, VideoLibrary video)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("DeleteVideos", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@VideoID", video.VideoId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void FetchId(DataGridView datagridView)
        {
            VideoLibrary video = new VideoLibrary();
            DataGridViewRow selectedRow = datagridView.SelectedRows[0];
            video.VideoId = selectedRow.Cells["VideoID"].Value.ToString();

            Delete(datagridView, video);

        }
       
    }
}

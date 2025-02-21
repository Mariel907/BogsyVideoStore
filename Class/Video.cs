using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project.Class
{
    public class Video
    {
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
                        cmd.Parameters.AddWithValue("@Genre", video.Genre);
                        cmd.Parameters.AddWithValue("@Category", video.Category);
                        cmd.Parameters.AddWithValue("@SerialNumber", video.SerialNumber);
                        cmd.Parameters.AddWithValue("@Rating", video.Rating);
                        cmd.Parameters.AddWithValue("@ReleaseDate", video.ReleaseDate);
                        cmd.Parameters.AddWithValue("@In", video.CopiesAvailable);
                        cmd.Parameters.AddWithValue("@Out", video.CopiesAvailable);
                        cmd.Parameters.AddWithValue("@Director", video.Director);

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

            }
            return false;

        }
    }
}

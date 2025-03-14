using Project.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Project.Class
{
    public class VideoLibrary
    {

        public bool Update(VideoProp video)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UpdateVideo", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("VideoID", video.VideoId);
                    cmd.Parameters.AddWithValue("Title", video.Title);
                    cmd.Parameters.AddWithValue("Category", video.Category);
                    cmd.Parameters.AddWithValue("Out", video.CopiesAvailable);

                    if (video.Category == "DVD")
                        cmd.Parameters.AddWithValue("Amount", 50);
                    else
                        cmd.Parameters.AddWithValue("Amount", 25);

                    cmd.ExecuteNonQuery();
              
                }
                return true;
            }
        }
        public bool Insert(VideoProp video)
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
                        cmd.Parameters.AddWithValue("@LimitDaysRented", video.LimitDaysRented);

                        if (video.Category == "DVD")
                            cmd.Parameters.AddWithValue("@Amount", 50);
                        else
                            cmd.Parameters.AddWithValue("@Amount", 25);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(VideoProp video)
        {
            try
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
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Class == 16)
                    return false;
                else
                    throw;
            }
        }
    }
}

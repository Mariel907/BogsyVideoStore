using Project.Model;
using System.Data.SqlClient;

namespace Project.Class
{
    public class VideoLibrary
    {
        private DataLoader ds = new DataLoader();

        public void Update(VideoProp video)
        {
            SqlParameter[] parameter;
            if (video.Category == "DVD")
                parameter = new SqlParameter[]
                {
                    new SqlParameter("Amount", 50),
                    new SqlParameter("VideoID", video.VideoId),
                    new SqlParameter("Title", video.Title),
                    new SqlParameter("Category", video.Category),
                    new SqlParameter("Out", video.CopiesAvailable),
                };
            else
                parameter = new SqlParameter[]
                {
                    new SqlParameter("Amount", 25),
                    new SqlParameter("VideoID", video.VideoId),
                    new SqlParameter("Title", video.Title),
                    new SqlParameter("Category", video.Category),
                    new SqlParameter("Out", video.CopiesAvailable),
                };

            ds.ExecuteData("UpdateVideo", parameter);
        }
        public void Insert(VideoProp video)
        {
            SqlParameter[] parameter;
            if (video.Category == "DVD")
                parameter = new SqlParameter[]
                {
                    new SqlParameter("Amount", 50),
                    new SqlParameter("Title", video.Title),
                    new SqlParameter("Category", video.Category),
                    new SqlParameter("In", video.CopiesAvailable),
                    new SqlParameter("LimitDaysRented", video.LimitDaysRented),
                };
            else
                parameter = new SqlParameter[]
                {
                    new SqlParameter("Amount", 25),
                    new SqlParameter("Title", video.Title),
                    new SqlParameter("Category", video.Category),
                    new SqlParameter("In", video.CopiesAvailable),
                    new SqlParameter("LimitDaysRented", video.LimitDaysRented),
                };

            ds.ExecuteData("InsertVideo", parameter);
        }

        public void Delete(VideoProp video)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@VideoID", video.VideoId)
            };
            ds.ExecuteData("DeleteVideos", parameter);
        }
    }
}

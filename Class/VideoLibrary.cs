﻿using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

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
                    new SqlParameter("Out", video.LimitDaysRented),
                };
            else
                parameter = new SqlParameter[]
                {
                    new SqlParameter("Amount", 25),
                    new SqlParameter("VideoID", video.VideoId),
                    new SqlParameter("Title", video.Title),
                    new SqlParameter("Category", video.Category),
                    new SqlParameter("Out", video.LimitDaysRented),
                };

            ds.ExecuteData("UpdateVideo", parameter);
        }

        public int LastVideoID()
        {
            using(SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("LastVideoID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                object result = cmd.ExecuteScalar();
                return result != null? (int)Convert.ToInt32(result) : 0;
            }
        }
        
        public void Insert(DataGridView DGV)
        {
            foreach (DataGridViewRow row in DGV.Rows)
            {
                if (row.IsNewRow) continue;

                int EntryNo = AutoIncrementManager.GetNextEntryNo();
                string DocumentNo = AutoIncrementManager.GetNextDocumentNo();
                int SerialID = AutoIncrementManager.GetNextSerialID();
                int NextVideoID = AutoIncrementManager.LastVideoID();

                object videoCellValue = row.Cells["VideoID"].Value;

                int VideoID = (videoCellValue != null) ? Convert.ToInt32(videoCellValue) : NextVideoID;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("Amount", row.Cells["Price"].Value),
                    new SqlParameter("Title", row.Cells["Title"].Value),
                    new SqlParameter("Category",  row.Cells["Category"].Value),
                    new SqlParameter("In", row.Cells["Qty"].Value),
                    new SqlParameter("LimitDaysRented", row.Cells["LimitDaysRented"].Value),
                    new SqlParameter("VideoID", VideoID),
                    new SqlParameter("SerialNo", row.Cells["SerialNo"].Value),
                    new SqlParameter("Date", DateTime.Now.Date),
                    new SqlParameter("UpdateDate", DateTime.Now.Date),
                    new SqlParameter("DocumentNo", DocumentNo),
                    new SqlParameter("EntryNo", EntryNo),
                    new SqlParameter("SerialID", SerialID)
                };
                ds.ExecuteData("InsertVideo", parameters);
            }
        }

        public List<string> DuplicateSerialNo(DataGridView DGV)
        {
            List<string> duplicatesInDB = new List<string>();

            var serialNumbers = DGV.Rows.Cast<DataGridViewRow>()
            .Where(row => !row.IsNewRow &&
                          row.Cells["SerialNo"].Value != null &&
                          !string.IsNullOrEmpty(row.Cells["SerialNo"].Value.ToString()))
            .Select(row => row.Cells["SerialNo"].Value.ToString())
            .Distinct()
            .ToList();
            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                foreach (var serialNo in serialNumbers)
                {
                    SqlCommand cmd = new SqlCommand("ReadSerialNo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("SerialNo", serialNo);
                    object result = cmd.ExecuteScalar();
                    int count = result == null ? 0 : Convert.ToInt32(result); 

                    if (count > 0)
                        duplicatesInDB.Add(serialNo);
                }
            }
            return duplicatesInDB;
        }
    
        public void Delete(VideoProp video)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@VideoID", video.VideoId)
            };
            ds.ExecuteData("DeleteVideos", parameter);
        }

        public static List<VideoProp> ShowAllVideo()
        {
            List<VideoProp> video = new List<VideoProp>();

            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ShowVideo", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        video.Add(new VideoProp
                        {
                            Title = reader["Title"].ToString(),
                            VideoId = int.Parse(reader["VideoID"].ToString()),
                            LimitDaysRented = int.Parse(reader["LimitDaysRented"].ToString()),
                            Price = Convert.ToDecimal(reader["Amount"].ToString()),
                            Category = reader["Category"].ToString().Trim(),
                            SerialNo = reader["SerialNo"].ToString(),
                            SerialID = int.Parse(reader["SerialID"].ToString())
                        });
                    }
                }
            }
            return video;
        }
      
    }
}

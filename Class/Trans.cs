using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Class
{
    public class Trans
    {
        private DataLoader ds = new DataLoader();

        public void Return(MTransac transac)
        {
            string DocsNo = AutoIncrementManager.GetNextDocumentNo();
            int EntryNo = AutoIncrementManager.GetNextEntryNo();
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@VideoID", transac.VideoID),
                new SqlParameter("@RentalID", transac.RentalId),
                new SqlParameter("DocumentNo", DocsNo),
                new SqlParameter("EntryNo", EntryNo),
                new SqlParameter("SerialNo", transac.SerialNo),
                new SqlParameter("SerialID", transac.SerialID)
            };
            ds.ExecuteData("UpdateReturn", parameter);
        }

        public void RefreshSearchCMBXTxbxRented(string SDate, string EDate, string cmbx, string Txbx, DataGridView dt)
        {
            string query = string.Empty;
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("SearchText", Txbx),
                new SqlParameter("StartDate", SDate),
                new SqlParameter("EndDate", EDate),
                new SqlParameter("Category", cmbx)
            };
            ds.LoadData("GetAllRentedTxbxDVD", dt, parameter);
        }

        public static List<SrchSerial> SearchSerialReturn()
        {
            List<SrchSerial> search = new List<SrchSerial>();
            using(SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SearchSerialReturn", con);
                cmd.CommandType = CommandType.StoredProcedure;

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        search.Add(new SrchSerial
                        {
                            Title = reader["Title"].ToString(),
                            SerialID = reader["SerialID"].ToString(),
                            SerialNo = reader["SerialNo"].ToString(),
                            VideoID = int.Parse(reader["VideoID"].ToString()),
                            Category = reader["Category"].ToString(),
                            Fullname = reader["Fullname"].ToString(),
                            RentalID = int.Parse(reader["RentalID"].ToString())
                        });
                    }
                }
            }
            return search;
        }
    }
}

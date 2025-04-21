using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project.Class
{
    public class CEFDashboard
    {
        private DataLoader loader = new DataLoader();
        public static List<MEarnings> GetAllEarnings(string SDate, string EDate)
        {
            List<MEarnings> mEarnings = new List<MEarnings>();
            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("ShowDashboard", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("StartDate", SDate);
                    cmd.Parameters.AddWithValue("EndDate", EDate);
                    cmd.Parameters.AddWithValue("Action", "Earnings");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mEarnings.Add(new MEarnings
                            {
                                Amount = reader["Amount"].ToString(),
                                RentDate = Convert.ToDateTime(reader["RentDate"].ToString()),
                                Penalty = reader["Penalty"].ToString(),
                                Category = reader["Category"].ToString(),
                                Title = reader["Title"].ToString(),
                            });
                        }
                    }
                }
            }
            return mEarnings;
        }

        public void CountLbl(ref string lbl, string SDate, string EDate, string Action)
        {
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("Action", Action),
                new SqlParameter("StartDate", SDate),
                new SqlParameter("EndDate", EDate)
            };
            int count = loader.LblUpdate("PnlDashboardEarnings", sp);

            lbl = "P" + count.ToString("N2");
        }
        public void UpdateDGV(DateTime SDate, DateTime EDate, DataGridView DGV)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("StartDate", SDate),
                new SqlParameter("EndDate", EDate)
            };
            loader.LoadData("GetAllEarnings", DGV, param);
        }

        public static List<MAvailableVideo> GetAllAvailableVideo()
        {
            return ExecuteStoredProcedure("ShowDashboard", new Dictionary<string, object> { { "Action", "AvailableVideo" } }, reader => new MAvailableVideo
            {
                Title = reader["Title"].ToString(),
                Category = reader["Category"].ToString(),
                CopiesAvailable = int.Parse(reader["CopiesAvailable"].ToString()),
            });
        }

        public static List<MDueRent> GetAllDueRent()
        {
            return ExecuteStoredProcedure("ShowDashboard", new Dictionary<string, object> { { "Action", "OverdueRent" } }, reader => new MDueRent
            {
                Category = reader["Category"].ToString(),
                Title = reader["Title"].ToString(),
                Fullname = reader["Fullname"].ToString(),
                DueDate = Convert.ToDateTime(reader["DueDate"].ToString())
            });
        }

        public static List<MRented> GetAllRented()
        {
            return ExecuteStoredProcedure("ShowDashboard", new Dictionary<string, object> { { "Action", "Rented" } }, reader => new MRented
            {
                Category = reader["Category"].ToString(),
                Title = reader["Title"].ToString(),
                Fullname = reader["Fullname"].ToString(),
                RentDate = Convert.ToDateTime(reader["RentDate"].ToString()),
                SerialNo = reader["SerialNo"].ToString()
            });
        }

        public static List<MTotalVideo> GetAllTotalVideo()
        {
            return ExecuteStoredProcedure("ShowDashboard", new Dictionary<string, object> { { "Action", "TotalVideo" } }, reader => new MTotalVideo
            {
                Category = reader["Category"].ToString(),
                Title = reader["Title"].ToString(),
                Out = int.Parse(reader["Out"].ToString())
            });
        }

        public static List<MReturned> GetMReturned()
        {
            return ExecuteStoredProcedure("ShowDashboard", new Dictionary<string, object> { { "Action", "Returned" } }, reader => new MReturned
            {
                Category = reader["Category"].ToString(),
                Title = reader["Title"].ToString(),
                SerialNo = reader["SerialNo"].ToString(),
                Fullname = reader["Fullname"].ToString(),
                ReturnDate = Convert.ToDateTime(reader["ReturnDate"].ToString()),
            });
        }
        public static List<T> ExecuteStoredProcedure<T>(string storeProcedureName, Dictionary<string, object> parameters, Func<SqlDataReader, T> mapFunction)
        {
            List<T> result = new List<T>();
            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(storeProcedureName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.AddWithValue(parameter.Key, parameter.Value ?? DBNull.Value);
                    }
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result.Add(mapFunction(reader));
                        }
                    }
                }
            }
            return result;
        }
    }
}

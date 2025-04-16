using Project.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
    public class CEFEarnings
    {
        private DataLoader loader = new DataLoader();
        public static List<MEarnings> GetAllEarnings(string SDate, string EDate)
        {
            List<MEarnings> mEarnings = new List<MEarnings>();
            using (SqlConnection con = new SqlConnection(GlobalConnection.Connection))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("GetAllEarnings", con))
                {   
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("StartDate", SDate);
                    cmd.Parameters.AddWithValue("EndDate", EDate);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mEarnings.Add(new MEarnings
                            {
                                Amount = reader["Amount"].ToString(),
                                RentDate = Convert.ToDateTime(reader["RentDate"].ToString()),
                                Penalty = reader["Penalty"].ToString()
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
    }
}

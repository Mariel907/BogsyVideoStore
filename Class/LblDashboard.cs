using System.Data.SqlClient;

namespace Project.Class
{
    public class LblDashboard
    {
        DataLoader loader = new DataLoader();
        public void Earnings( ref string lblEarnings)
        {
            string Action = "Earnings";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("Action", Action)
            };
            int count = loader.LblUpdate("LblDashboard", sp);

            lblEarnings = "P" + count.ToString("N2");
        }
        public void TotalVideo(ref string lbl)
        {
            CountLbl(ref lbl, "TotalVideo");
        }
        private void CountLbl(ref string lbl, string Action)
        {
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("Action", Action)
            };
            int count = loader.LblUpdate("LblDashboard", sp);

            lbl = count.ToString();
        }

        public void AvailableVideo(ref string lbl)
        {
            CountLbl(ref lbl, "AvailableVideo");
        }

        public void Rented(ref string lbl)
        {
            CountLbl(ref lbl, "Rented");
        }

        public void Overdue(ref string lbl)
        {
            CountLbl(ref lbl, "Overdue");
        }
        public void Return(ref string lbl)
        {
            CountLbl(ref lbl, "Return");
        }

    }
}

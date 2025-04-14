using Project.Forms;

namespace Project.Model
{
    public class MFDashboard
    {
        private FDashboard fDashboard;
        public MFDashboard(FDashboard fDashboard)
        {
            this.fDashboard = fDashboard;
        }
        public string Earnings
        {
            get { return fDashboard.Earningslbl; }
            set { fDashboard.Earningslbl = value; }
        }
        public string AvailableVideo
        {
            get { return fDashboard.AvailableVideoLbl; }
            set { fDashboard.AvailableVideoLbl = value; }
        }
        public string OverdueRental { get; set; }
        public string Rented { get; set; }
        public string TotalVideo { get; set; }
        public string Return { get; set; }
    }
}

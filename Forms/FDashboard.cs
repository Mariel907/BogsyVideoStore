using Project.Class;
using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class FDashboard : Form
    {
        public string Earningslbl { get { return lblEarnings.Text; } set { lblEarnings.Text = value; } }
        public string AvailableVideoLbl { get { return lblAvailableVideo.Text; } set { lblAvailableVideo.Text = value; } }
        public string OverdueRentLbl { get { return lblOverdueRent.Text; } }
        public string RentedLbl { get { return lblRented.Text; } }
        public string TotalVideoLbl { get { return LblTotalVideo.Text; } }
        public string Returnedlbl { get { return LblReturned.Text; } }


        public FDashboard()
        {
            InitializeComponent();
        }
        private void FDashboard_Load(object sender, EventArgs e)
        {
            Updatelabel();
        }

        private void Updatelabel()
        {
            LblDashboard lbl = new LblDashboard();
            string update = string.Empty;
          
            lbl.Earnings(ref update);
            lblEarnings.Text = update;

            lbl.TotalVideo(ref update);
            LblTotalVideo.Text = update;

            lbl.AvailableVideo(ref update);
            lblAvailableVideo.Text = update;

            lbl.Rented(ref update);
            lblRented.Text = update;

            lbl.Overdue(ref update);
            lblOverdueRent.Text = update;

            lbl.Return(ref update);
            LblReturned.Text = update;
        }
    }
}

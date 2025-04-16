using Project.Class;
using Project.Forms.ExtensionForms;
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

        private FormManager form = new FormManager();
        private Dashboard _dashboard = new Dashboard();
        public FDashboard(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
        }
        private void FDashboard_Load(object sender, EventArgs e)
        {
            Updatelabel();
            ChangedColorDue();
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

        private void ChangedColorDue()
        {
            Color colorRed = Color.FromArgb(192, 0, 0);
            Color colorBlue = Color.FromArgb(0, 138, 162);
            if (lblOverdueRent.Text == "0")
            {
                PnlOverdueRent.BackColor = colorBlue;
                LblTitleDue.BackColor = colorBlue;
                PctrDue.BackColor = colorBlue;
                lblOverdueRent.BackColor = colorBlue;
            }
            else
            {
                PnlOverdueRent.BackColor = colorRed;
                LblTitleDue.BackColor = colorRed;
                PctrDue.BackColor = colorRed;
                lblOverdueRent.BackColor = colorRed;
            }
        }

        private void PnlBackEarnings_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void PnlBackEarnings_Click(object sender, EventArgs e)
        {
            EFEarnings earnings = new EFEarnings();
            form.OpenForm(earnings, _dashboard.Panel);
        }
    }
}

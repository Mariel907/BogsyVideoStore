using Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class EFEarnings : Form
    {
        private CEFEarnings _CEFEarnings = new CEFEarnings();
        private string SDate;
        private string EDate;
        public EFEarnings()
        {
            InitializeComponent();
        }

        private void EFEarnings_Load(object sender, EventArgs e)
        {
            UpdateLable();
            CalendarValue();
            CalendarSearch();
        }
        private void CalendarValue()
        {
            DTPStartEarnings.Value = DateTime.Now.Date;
            DTPEndEarnings.Value = DateTime.Now.Date;
        }
        private void UpdateLable()
        {
            string Amount = string.Empty;
            string Penalty = string.Empty;
            string GrandTotal = string.Empty;
            SDate = DTPStartEarnings.Value.ToString();
            EDate = DTPEndEarnings.Value.ToString();
            _CEFEarnings.CountLbl(ref Amount, SDate, EDate, "Amount");
            lblAmount.Text = Amount;
            _CEFEarnings.CountLbl(ref Penalty, SDate, EDate, "Penalty");
            lblPenalty.Text = Penalty;
            _CEFEarnings.CountLbl(ref GrandTotal, SDate, EDate, "GrandTotal");
            lblGrandTotal.Text = GrandTotal;


        }
        private void CalendarSearch()
        {
            SDate = DTPStartEarnings.Value.ToString();
            EDate = DTPEndEarnings.Value.ToString();
            DGVEarnings.DataSource = CEFEarnings.GetAllEarnings(SDate, EDate);
        }

        private void DTPEndReturned_ValueChanged(object sender, EventArgs e)
        {
            CalendarSearch();
            UpdateLable();
        }

        private void DTPStartEarnings_ValueChanged(object sender, EventArgs e)
        {
            CalendarSearch();
            UpdateLable();
        }
       
    }
}

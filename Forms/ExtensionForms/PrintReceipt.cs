using Microsoft.Reporting.WinForms;
using Project.Class;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class PrintReceipt : Form
    {
        private List<VideoProp> videoList;
        private Customers customers;
        public PrintReceipt(Customers customer, List<VideoProp> videoList)
        {
            InitializeComponent();
            this.videoList = videoList;
            customers = customer;
        }

        private void PrintReceipt_Load(object sender, EventArgs e)
        {
            RentReceiptGenerator GntrReceipt = new RentReceiptGenerator(RptrViewerRent);
            GntrReceipt.GenerateReceipt(customers, videoList);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

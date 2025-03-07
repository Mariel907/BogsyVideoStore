using Microsoft.Reporting.WinForms;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class PrintReceipt : Form
    {
        Receipt receipt;
        List<VideoProp> list;
        public PrintReceipt(Receipt receipt, List<VideoProp> list)
        {
            InitializeComponent();
            this.receipt = receipt;
            this.list = list;
        }

        private void PrintReceipt_Load(object sender, EventArgs e)
        {
            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("CustomerName", receipt.CustomerName),
                new ReportParameter("RentDate", receipt.RentDate.ToString("MM/dd/yyyy")),
                new ReportParameter("Cash", receipt.Cash.ToString("F2")),
                new ReportParameter("Change", receipt.Change.ToString("F2"))
            };
            this.reportViewer1.LocalReport.SetParameters(p);

            ReportDataSource dataSource = new ReportDataSource("DSReceipt", list);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);

            this.reportViewer1.RefreshReport();
        }
    }
}

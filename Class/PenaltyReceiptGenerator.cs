using Microsoft.Reporting.WinForms;
using Project.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace Project.Class
{
    public class PenaltyReceiptGenerator
    {
        private ReportViewer reportViewer;

        public PenaltyReceiptGenerator(ReportViewer reportViewer)
        {
            this.reportViewer = reportViewer;
        }

        public void GeneratePaymentReceipt(PenaltyReceipt penalty, string customerName, List<PenaltyReceipt> list)
        {
            ReportDataSource ds = new ReportDataSource("DataSet1", list);

            ReportParameter name = new ReportParameter("pCustomerName", customerName);
            ReportParameter rentdate = new ReportParameter("pDate", DateTime.Now.ToString("MM/dd/yyyy"));
            ReportParameter cash = new ReportParameter("pCash", "₱" + penalty.Cash.ToString("N2"));
            ReportParameter change = new ReportParameter("pChange", "₱" + penalty.Change.ToString("N2"));

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.ReportPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Forms\\ReportRDLC\\PaymentReceipt.rdlc");
            reportViewer.LocalReport.DataSources.Add(ds);
            reportViewer.LocalReport.SetParameters(new[] { name, rentdate, cash, change });
            reportViewer.RefreshReport();
        }

    }
}

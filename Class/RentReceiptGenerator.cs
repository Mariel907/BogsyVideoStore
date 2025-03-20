using Microsoft.Reporting.WinForms;
using Project.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace Project.Class
{
    public class RentReceiptGenerator
    {
        private ReportViewer reportViewer;
        public RentReceiptGenerator(ReportViewer reportViewer)
        {
            this.reportViewer = reportViewer;
        }

        public void GenerateReceipt(Customers customerProp, List<VideoProp> list)
        {
            reportViewer.LocalReport.ReportPath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, "Forms\\ReportRDLC\\Receipt.rdlc");

            ReportParameter[] p = new ReportParameter[]
            {
                new ReportParameter("CustomerName", customerProp.Fullname),
                new ReportParameter("RentDate", DateTime.Now.Date.ToString("MM/dd/yyyy")),
                new ReportParameter("Cash",  "₱" + customerProp.Cash.ToString("F2")),
                new ReportParameter("Change",  "₱" + customerProp.Change.ToString("F2")),
                new ReportParameter("ID", customerProp.CustomerID)
            };
            reportViewer.LocalReport.SetParameters(p);

            ReportDataSource dataSource = new ReportDataSource("DSReceipt", list);
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(dataSource);

            reportViewer.RefreshReport();
        }
    }
}

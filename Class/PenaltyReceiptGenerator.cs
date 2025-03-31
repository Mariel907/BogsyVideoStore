using Microsoft.Reporting.WinForms;
using Project.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

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
            reportViewer.LocalReport.SetParameters(new[] { name, rentdate, cash, change});
            reportViewer.RefreshReport();

          
        }

        //public string GntrPDFPenalty(string BtnPdf)
        //{
        //    string fileName = string.Empty;

        //    if (!string.IsNullOrEmpty(BtnPdf))
        //    {
        //        string deviceInfo = "<DeviceInfo><OutputFormat>PDF</OutputFormat></DeviceInfo>";
        //        Warning[] warnings;
        //        string[] streamids;
        //        byte[] renderedBytes;

        //        renderedBytes = reportViewer.LocalReport.Render("PDF", deviceInfo, out string mimeType, out string encoding, out string fileNameExtension, out streamids, out warnings);

        //        fileName = "PenaltyReceipt_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf";
        //        File.WriteAllBytes(fileName, renderedBytes);

        //        MessageBox.Show($"Paymewnt receipt has been successfully saved as {fileName}", "PDF Generated");
        //    }
        //    return fileName;
        //}

        //private void SendEmail(string emailRecipient)
        //{
        //    string filePath = "Receipt.pdf"; // Path to the generated PDF

        //    MailMessage mail = new MailMessage();
        //    mail.From = new MailAddress("your_email@example.com");
        //    mail.To.Add(emailRecipient);
        //    mail.Subject = "Your Receipt";
        //    mail.Body = "Please find the attached receipt.";
        //    mail.Attachments.Add(new Attachment(filePath));

        //    SmtpClient smtp = new SmtpClient("smtp.gmail.com"); // Replace with your SMTP server
        //    smtp.Port = 587; // Standard port for SSL
        //    smtp.Credentials = new NetworkCredential("your_email@example.com", "your_email_password");
        //    smtp.EnableSsl = true;

        //    smtp.Send(mail);
        //}
    }
}

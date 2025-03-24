using Guna.UI2.WinForms;
using Project.Class;
using Project.Forms.ExtensionForms;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class Dashboard : Form
    {
        private FormManager form = new FormManager();

        public Panel Panel { get { return panelDashboard; } }
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                SetButtonNames();
                UpdateButtonColors(button.Name);
                OpenCorrespondingForm(button.Name);
            }
        }

        private void SetButtonNames()
        {
            guna2ButtonDVDVCD.Name = "DVDVCD";
            guna2ButtonCustomer.Name = "Customer";
            guna2ButtonTransactions.Name = "Transactions";
            guna2ButtonReports.Name = "Reports";
            guna2ButtonPayments.Name = "Payments";
        }
        private void UpdateButtonColors(string ActiveButton)
        {
            Color ActiveColor = Color.FromArgb(0, 50, 73);
            Color InActiveColor = Color.FromArgb(0, 138, 162);
            Color BorderActive = Color.White; 
            Color BorderInActive = Color.Transparent;

            guna2ButtonDVDVCD.FillColor = ActiveButton == "DVDVCD"? ActiveColor : InActiveColor;
            guna2ButtonDVDVCD.BorderColor = ActiveButton == "DVDVCD"? BorderActive : BorderInActive;
            guna2ButtonCustomer.FillColor = ActiveButton == "Customer" ? ActiveColor : InActiveColor;
            guna2ButtonCustomer.BorderColor = ActiveButton == "Customer" ? BorderActive : BorderInActive;
            guna2ButtonTransactions.FillColor = ActiveButton == "Transactions" ? ActiveColor :InActiveColor;
            guna2ButtonTransactions.BorderColor = ActiveButton == "Transactions" ? BorderActive : BorderInActive;
            guna2ButtonReports.FillColor = ActiveButton == "Reports" ? ActiveColor :InActiveColor;
            guna2ButtonReports.BorderColor = ActiveButton == "Reports" ? BorderActive : BorderInActive;
            guna2ButtonPayments.FillColor = ActiveButton == "Payments" ? ActiveColor :InActiveColor;
            guna2ButtonPayments.BorderColor = ActiveButton == "Payments" ? BorderActive : BorderInActive;
        }
        private void OpenCorrespondingForm(string buttonName)
        {
            switch (buttonName)
            {
                case "DVDVCD":
                    DVDs_VCDs dVDs_VCDs = new DVDs_VCDs(this);
                    form.OpenForm(dVDs_VCDs, panelDashboard);
                    break;
                case "Customer":
                    CustomerForm customer = new CustomerForm();
                    form.OpenForm(customer, panelDashboard);
                    break;
                case "Transactions":
                    Transaction trans = new Transaction(this);
                    form.OpenForm(trans, panelDashboard);
                    break;
                case "Reports":
                    DGVReports reports = new DGVReports();
                    form.OpenForm(reports, panelDashboard);
                    break;
                case "Payments":
                    Payments payments = new Payments();
                    form.OpenForm(payments, panelDashboard);
                    break;
                default:
                    break;
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            DVDs_VCDs video = new DVDs_VCDs(this);
            FormManager form = new FormManager();
            form.OpenForm(video, panelDashboard);
            guna2ButtonDVDVCD.FillColor = Color.FromArgb(0, 50, 73);
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

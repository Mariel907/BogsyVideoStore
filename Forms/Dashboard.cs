using Guna.UI2.WinForms;
using Project.Class;
using Project.Forms.ExtensionForms;
using System;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class Dashboard : Form
    {
        public Panel Panel { get { return panelDashboard; } }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form_Click(object sender, EventArgs e)
        {
            FormManager form = new FormManager();

            if (sender is Guna2Button button)
            {
                guna2ButtonDVDVCD.Name = "DVDVCD";
                guna2ButtonCustomer.Name = "Customer";
                guna2ButtonTransactions.Name = "Transactions";
                guna2ButtonReports.Name = "Reports";
                guna2ButtonPayments.Name = "Payments";

                switch (button.Name)
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
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DVDs_VCDs video = new DVDs_VCDs(this);
            FormManager form = new FormManager();
            form.OpenForm(video, panelDashboard);
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

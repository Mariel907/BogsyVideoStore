using Guna.UI2.WinForms;
using Project.Class;
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

                switch (button.Name)
                {
                    case "DVDVCD":
                        DVDs_VCDs dVDs_VCDs = new DVDs_VCDs(this);
                        form.OpenForm(dVDs_VCDs, panelDashboard);
                        break;
                    case "Customer":
                        CustomerForm customer = new CustomerForm(this);
                        form.OpenForm(customer, panelDashboard);
                        break;
                    case "Transactions":
                        Transaction trans = new Transaction();
                        form.OpenForm(trans, panelDashboard);
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

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}

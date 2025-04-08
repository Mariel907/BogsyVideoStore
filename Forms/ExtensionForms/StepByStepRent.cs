using Guna.UI2.WinForms;
using Project.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms.ExtensionForms
{
    public partial class StepByStepRent : Form
    {
        public Panel StepByStepPanel { get{ return PnlStepByStep; } }
        public Guna2Button BookBtn { get {return Item; } }
        public Guna2Button CustomerBtn { get {return G2BtnCustomer; } }
        public StepByStepRent()
        {
            InitializeComponent();
        }

        private void StepByStepRent_Load(object sender, EventArgs e)
        {
            TransSelectCustomer select = new TransSelectCustomer(this);
            FormManager form = new FormManager();
            form.OpenForm(select, PnlStepByStep);
        }
    }
}

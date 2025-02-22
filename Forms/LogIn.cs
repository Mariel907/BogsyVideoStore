using Project.Class;
using Project.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void guna2ButtonLogIn_Click(object sender, EventArgs e)
        {
            string email = guna2TextBoxUserName.Text;
            string password = guna2TextBoxPassword.Text;
            
            if (email == "Bogsy@gmail.com" || password == "Admin123")
            {
                guna2HtmlLabelHideError.Show();
                guna2HtmlLabelShowError.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                this.Hide();
             }
        }

        private void guna2ButtonSignUp_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

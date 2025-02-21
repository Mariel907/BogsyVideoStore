﻿using Project.Class;
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
        private Security _security = new Security();
        public LogIn()
        {
            InitializeComponent();
        }

        private void guna2ButtonLogIn_Click(object sender, EventArgs e)
        {
            string email = guna2TextBoxUserName.Text;
            string password = guna2TextBoxPassword.Text;

            _security.LogInClick(email, password);

            if (email != UserLogin.Email || password != UserLogin.Password)
            {
                MessageBox.Show("Invalid Username or Password");
                guna2HtmlLabelHideError.Hide();
                guna2HtmlLabelShowError.Show(); 
            }
            else
            {
                this.Hide();
                _security.OpenForm(UserLogin.Role);

             }
        }
    }
}

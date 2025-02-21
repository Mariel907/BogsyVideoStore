using Project.Forms;
using Project.Model;
using Project.userForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Class
{
    public class Security
    {
        public bool LogInClick(string email, string password)
        {
            if(Authentication(email, password, out string Role, out int ID, out string firstname, out string lastname, out string _password))
            {
                UserLogin.Email = email;
                UserLogin.Password = _password;
                UserLogin.Role = Role;
                UserLogin.UserID = ID;
                UserLogin.FullName = $"{firstname} {lastname}";

                return true;
            }
            return false;
        }
        public bool Authentication(string email, string password, out string Role, out int ID, out string firstname, out string lastname, out string _password)
        {
            Role = string.Empty;
            ID = -1;
            firstname = string.Empty;
            lastname = string.Empty;
            _password = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalConnection.Connection))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("AuthenticateUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        SqlDataReader reader = cmd.ExecuteReader();
                        
                        reader.Read();

                        ID = Convert.ToInt32(reader["CustomerID"]);
                        Role = reader["Role"]?.ToString();
                        firstname = reader["FirstName"]?.ToString();
                        lastname = reader["LastName"]?.ToString();
                        _password = password;

                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void OpenForm(string role)
        {
            if (role == "user")
            {
                UserDashboard userDashboard = new UserDashboard();
                userDashboard.Show();
                LogIn login = new LogIn();
                login.Hide();
            }
            else if (role == "admin")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                LogIn login = new LogIn();
                login.Hide();
            }
        }
    }
}

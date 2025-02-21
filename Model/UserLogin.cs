using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class UserLogin
    {
        public static string Role {  get; set; }
        public static string Email { get; set; }
        public static int UserID { get; set; }
        public static string FullName { get; set; }
        public static string Password { get; set; }
    }
}

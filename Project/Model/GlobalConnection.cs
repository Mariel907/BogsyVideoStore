using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class GlobalConnection
    {
        public static string Connection { get; } = "Data Source=(local);Initial Catalog=BogsyVideoStore;Integrated Security=True;TrustServerCertificate=True";
    }
}

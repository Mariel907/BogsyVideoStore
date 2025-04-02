using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class CustomerProp
    {
        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Customers
    {
        public string  CustomerID { get; set; }
        public string Fullname { get; set; }
        public decimal Cash { get; set; }
        public decimal Change { get; set; }
        public string SerialNo { get; set; }
    }
}

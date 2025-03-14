using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Receipt
    {
        public string CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public decimal Cash { get; set; }
        public decimal Change { get; set; }
    }

}

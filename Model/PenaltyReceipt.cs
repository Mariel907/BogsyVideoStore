using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Model
{
    public class PenaltyReceipt
    {
        public string RentalID { get; set; }
        public string Fullname { get; set; }
        public  string Qty { get; set; }
        public string  Title { get; set; }
        public string Category { get; set; }
        public decimal Penalty { get; set; }
        public decimal Change { get; set; }
        public decimal Cash { get; set; }
        public string SerialNo { get; set; }
        public string CustomerID { get; set; }
    }
}

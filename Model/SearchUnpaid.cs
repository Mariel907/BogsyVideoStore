using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class SearchUnpaid
    {
        public string  CustomerID { get; set; }
        public string RentalID { get; set; }
        public string Fullname { get; set; }
        public string Title { get; set; }
        public string Penalty { get; set; }
        public string Qty { get; set; }
        public string Category { get; set; }
        public string SerialNo { get; set; }
    }
}

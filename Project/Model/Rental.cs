using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class Rental
    {
        public int RentalID { get; set; }
        public int CustomerID { get; set; }
        public int VideoID { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime Returndate { get; set; }
        public DateTime DueDate { get; set; }
        public Decimal Penalty { get; set; }
        public string Status  { get; set; }
    }
}

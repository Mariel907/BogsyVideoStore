using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class MTransac
    {
        public string VideoID { get; set; }
        public string RentalId {  get; set; }
        public string DocumentNo { get; set; }
        public string  Title { get; set; }
        public string  SerialNo { get; set; }
        public int EntryNo { get; set; }
        public int SerialID { get; set; }
        public int CustomerID { get; set; }
        public string Fullname { get; set; }
        public string Category { get; set; }
        public int Qty { get; set; }
        public DateTime Duedate { get; set; }
    }
}

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
        public List<VideoProp> RentedVideos { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Cash { get; set; }
        public decimal Change { get; set; }

        public Receipt()
        {
            RentedVideos = new List<VideoProp>();
        }
    }

}

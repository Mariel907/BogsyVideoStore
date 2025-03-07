using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class VideoProp
    {
        public int VideoId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string CopiesAvailable { get; set; }
        public int LimitDaysRented { get; set; }
        public Decimal Price { get; set; }
        public DateTime DueDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }

    }
}

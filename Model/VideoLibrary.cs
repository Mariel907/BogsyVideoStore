using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class VideoLibrary
    {
        public string VideoId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string CopiesAvailable { get; set; }
        public string LimitDaysRented { get; set; }
    }
}

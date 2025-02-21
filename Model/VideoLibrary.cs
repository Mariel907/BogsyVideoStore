using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class VideoLibrary
    {
        public int VideoId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Category { get; set; }
        public string SerialNumber { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CopiesAvailable { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Model
{
    public class MLedger
    {
        public string DocumentNo { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string SerialNo { get; set; }
        public int Qty { get; set; }
        public string LedType { get; set; }
    }
}

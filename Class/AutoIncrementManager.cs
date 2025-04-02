using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Class
{
    public static class AutoIncrementManager
    {
        private static int counter = 1000;
        private static int EntryNoCount = 1;
        private static int SerialNoCount = 100;
        
        public static string GetNextDocumentNo( string prefix = "D")
        {
            return $"{prefix} {counter++}";
        }

        public static int GetNextEntryNo(string prefix = "E")
        {
            return EntryNoCount++;
        }

        public static int GetNextSerialID()
        {
            return SerialNoCount;
        }
    }
}

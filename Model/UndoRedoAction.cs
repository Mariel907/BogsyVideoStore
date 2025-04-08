using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Model
{
    class UndoRedoAction
    {
        public int RowIndex { get; set; }
        public int CellIndex { get; set; } = -1;
        public object PreviousCellValue { get; set; }
        public object[] Cells { get; set; }
    }
}

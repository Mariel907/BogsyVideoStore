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
        public DataGridViewCell Cell { get; set; }
        public object PreviousValue {  get; set; }
        public object[] Cells { get; set; }
    }
}

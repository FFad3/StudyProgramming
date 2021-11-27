using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class WorkPereformedEventArgs : System.EventArgs
    {
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}

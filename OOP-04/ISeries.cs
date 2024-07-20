using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04
{
    internal interface ISeries
    {
        public int cuurent {  get; set; }
        public void GetNext();
        public void Reset();
    }
}

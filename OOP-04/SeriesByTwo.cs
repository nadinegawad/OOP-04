using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04
{
    internal class SeriesByTwo : ISeries
    {
        public int cuurent { get; set; }

        public void GetNext()
        {
            cuurent += 2;
        }

        public void Reset()
        {
            cuurent = 0;
        }
    }
}

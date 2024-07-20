using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04
{
    internal class SeriesByThree : ISeries
    {
        public int cuurent { get ; set; }

        public void GetNext()
        {
            cuurent += 3;
        }

        public void Reset()
        {
            cuurent = 0;
        }
    }
}

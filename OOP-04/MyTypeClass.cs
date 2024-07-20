using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04
{
    internal class MyTypeClass : IMyType
    {
        public int id { get ; set ; }

        public void MyFun(int x)
        {
            Console.WriteLine($"Hello Route X : {x} ID : {id}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04
{
    internal interface IMyType
    {
        public int id { get; set; }
        public void MyFun(int x);
        public void Print()
        {
            Console.WriteLine($"Hello default implemented method");
        }
    }
}

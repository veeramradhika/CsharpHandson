using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add obj1 = new Add();
            obj1.AddNumb();
            obj1.sub();
            Console.ReadLine();
        }
    }
}

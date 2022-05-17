using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOper
{
    internal class Add
    {
       public int num1;
       public int num2;
       public int num3;
        public void AddNumb()
        {
            num1 = 10;
            num2 = 20;
            num3 = num1 + num2;
            Console.WriteLine("the addition of 10 and 20 is : " + num3);
        }
        public void sub()
        {
            num3 = num1 - num2;
            Console.WriteLine("the substraction of 10 and 20 is : " + num3);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraysHandsOn
{
    public class Array3
    {
        public void data()
        {
            bool[] a = new bool[10]
            {
                true,false,true,false,true,false,true,false,true,false
            };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Alternate truefalse" );
            Console.ReadLine();
        }
    }
}

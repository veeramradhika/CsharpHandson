using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraysHandsOn
{
    internal class Array1
    {
        public void numbers()
        {
            //defining array list
            ArrayList obj = new ArrayList();
            //adding elements
            obj.Add(0);
            obj.Add(1);
            obj.Add(2);
            obj.Add(3);
            obj.Add(4);
            obj.Add(5);
            obj.Add(7);
            obj.Add(8);
            obj.Add(9);
            // adding element to the particular position
            obj.Insert(6, 6);
            //Accessing arraylist
            for(int i=0; i<obj.Count;i++)
            {
                Console.WriteLine("At index [" + i + "]= " +obj[i]);
            }
            Console.WriteLine("Total numbers in array: " +obj.Count);
            Console.ReadLine();
        }
    }
}

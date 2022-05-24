using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace CountChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "veeram radhika";
            while (name.Length > 0)
            {
                int countOfChar = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[0] == name[i])
                    {
                        countOfChar++;
                    }
                }
                Console.WriteLine($"{name[0]}=" + $"{countOfChar}");
                name = name.Replace(name[0].ToString(), string.Empty);
                
            }
          
            Console.ReadLine();


        }
       
    }
}

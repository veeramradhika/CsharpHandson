using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArraysHandsOn
{
    public class Array2
    {
        public void names()
        {
            //creating generic list string type
            List<string> Names = new List<string>
            {
                "Tim", "Martin"
            };
            //accessing list elements
            foreach(string name in Names)
            {
                Console.WriteLine(name);
            }
            //Insert Element at Index Position 2
            Names.Insert(2, "Nikki");
            Console.WriteLine($"\nIndex of Nikki Element in the List : {Names.IndexOf("Nikki")}");

            //Creating another collection of string type
            List<string> newName = new List<string> { "Sara" };

            // Inserting the newCountries collection into list at Index 2 using InsertRange Method
            Names.InsertRange(3, newName);

            //accessing the list after inserting index
            foreach (string name in Names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Names in array: " + Names.Count);
            Console.ReadLine();
        }
    }
}

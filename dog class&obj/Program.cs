using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create Dog object 
            Dog dogobj = new Dog();
            dogobj.breed = "Bull Dog";
            Console.WriteLine(dogobj.breed);
            dogobj.bark();
            Console.ReadLine();
        }
    }
}

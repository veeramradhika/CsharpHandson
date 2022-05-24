using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHandsOn
{
    public class IceCreameFlavors
    {
        public void flavor()
        {
            List<string> flavor = new List<string>();
            flavor.Add("Chocloate");
            flavor.Add("Vanilla");
            flavor.Add("Strawberry");
            flavor.Add("Mango");
            flavor.Add("Oreo");
            for(int i=0; i<flavor.Count; i++)
            {
                Console.WriteLine(flavor[i] + " Ice cream");
            }
            Console.WriteLine("\nice cream flavors");
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingAndInventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserModule userModule = new UserModule();
            userModule.WriteFile();
            Console.WriteLine("user module completed..");


            CategoryModule categoryModule = new CategoryModule();
            categoryModule.WriteFile();
            Console.WriteLine("Cateogry module completed");


            ProductModule productModule = new ProductModule();
            productModule.WriteFile();
            Console.WriteLine("Product module completed");

            ProductAndSalesModule productAndSalesModule = new ProductAndSalesModule();
            productAndSalesModule.WrieFile();
            Console.WriteLine("Product and sales module completed");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingAndInventorySystem
{
    internal class ProductAndSalesModule
    {
        int salesId, productId;
        decimal price;
        DateTime salesDate;
        public void WrieFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\TrainingRepo\Product.txt", FileMode.Create, FileAccess.Write);
            StreamWriter Writerobj1 = new StreamWriter(fileStreamObj);
            Writerobj1.WriteLine("salesId\tproductId\tprice\tsalesDate");
            for (int i = 1; i < 6; i++)
            {


                Console.Write("Enter the salesId:");
                salesId = Convert.ToInt32(Console.ReadLine());
                Writerobj1.Write(salesId + "\t");

                Console.WriteLine("Enter the productId:");
                productId = Convert.ToInt32(Console.ReadLine());
                Writerobj1.Write(productId + "\t");

                Console.Write("Enter the price:");
                price = Convert.ToDecimal(Console.ReadLine());
                Writerobj1.Write(price + "\t");

                Console.Write("Enter the salesDate:");
                salesDate = Convert.ToDateTime(Console.ReadLine());
                Writerobj1.Write(salesDate + "\n");


            }
            Writerobj1.Close();
            fileStreamObj.Close();
            Console.WriteLine("Product and sales module completed");
        }
    }
}
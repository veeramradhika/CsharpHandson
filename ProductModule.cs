using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingAndInventorySystem
{
    internal class ProductModule
    {
        int productId;
        decimal price;
        string cateogryType, productName, quality;
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\TrainingRepo\Product.txt", FileMode.Create, FileAccess.Write);
            StreamWriter Writerobj1 = new StreamWriter(fileStreamObj);
            Writerobj1.WriteLine("productId\tcategoryType\tproductName\tquality\tprice");
            for (int i = 1; i < 6; i++)
            {


                Console.WriteLine("Enter the productId:");
                productId = Convert.ToInt32(Console.ReadLine());
                Writerobj1.Write(productId + "\t");


                Console.Write("Enter the CategoryType:");
                cateogryType = Convert.ToString(Console.ReadLine());
                Writerobj1.Write(cateogryType + "\t");

                Console.Write("Enter the productName:");
                productName = Convert.ToString(Console.ReadLine());
                Writerobj1.Write(productName + "\t");

                Console.Write("Enter the quality:");
                quality = Convert.ToString(Console.ReadLine());
                Writerobj1.Write(quality + "\t");

                Console.Write("Enter the price:");
                price = Convert.ToDecimal(Console.ReadLine());
                Writerobj1.Write(price + "\n");


            }
            Writerobj1.Close();
            fileStreamObj.Close();
            Console.WriteLine("Cateogry module completed");
        }
    }
}
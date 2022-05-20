using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingAndInventorySystem
{
    internal class CategoryModule
    {
        int CategoryId;
        string CategoryType;
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\TrainingRepo\Category.txt", FileMode.Create, FileAccess.Write);
            StreamWriter Writerobj1 = new StreamWriter(fileStreamObj);
            Writerobj1.WriteLine("CategoryId\tCategoryType\t");
            for (int i = 1; i < 6; i++)
            {


                Console.WriteLine("Enter the CategoryId:");
                CategoryId = Convert.ToInt32(Console.ReadLine());
                Writerobj1.Write(CategoryId + "\t");


                Console.Write("Enter the CategoryType:");
                CategoryType = Convert.ToString(Console.ReadLine());
                Writerobj1.Write(CategoryType + "\n");



            }
            Writerobj1.Close();
            fileStreamObj.Close();
            Console.WriteLine("Cateogry module completed");
        }
    }
}
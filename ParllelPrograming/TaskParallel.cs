using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections;

namespace ParllelPrograming
{
    public class TaskParallel
    {
        public void DisplayItem(string item)
        {
           Console.WriteLine(item);
        }
        public void ShowData()
        {
            List<string> list = new List<string>
            { 
                "keyboard","Mouse","Laptop","Mobile"
            };
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            //Parallel.ForEach(list,item=>DisplayItem(item));
            //ShowCustomerReport();
            //ShowEmployeeReport();
            Parallel.Invoke(ShowCustomerReport, ShowEmployeeReport);
  
        }
        public void ShowCustomerReport()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("ShowCustomerReport: " + i);
                Thread.Sleep(2000);
            }
        }
        public void ShowEmployeeReport()
        {
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("ShowEmployeeReport: " + i);
                Thread.Sleep(2000);
            }
        }
    }
}

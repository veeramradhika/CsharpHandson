using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNetHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeData employeeData = new EmployeeData();
            //employeeData.insertEmployee();
            //Console.ReadLine();  

            AccountData accountData = new AccountData();
            accountData.insertAccount();
        }
    }
}

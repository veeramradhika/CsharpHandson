using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount currentAccobj = new CurrentAccount();
            string output = currentAccobj.AccountName();
            int accountNumber = currentAccobj.AccountNumber();
            decimal accountBalance = currentAccobj.AccountBalance();
            string ATM = currentAccobj.ATM();
            Console.WriteLine("AccountName: " + output);
            Console.WriteLine("AccountNumber: " + accountNumber);
            Console.WriteLine("AccountBalance: " + accountBalance);
            
            Console.WriteLine("ATM status: " + ATM);
            Console.ReadLine();



        }
    }
}

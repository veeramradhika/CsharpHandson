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
            CurrentAccount obj1 = new CurrentAccount();
            obj1.GetCuurentAccountDetails();
            decimal accountBalance = obj1.AccountBalance();
            string ATM = obj1.Atm();

            Console.WriteLine("AccountBalance: " + accountBalance);
            Console.WriteLine("ATM status: " + ATM);

            CurrentAccount obj2 = new CurrentAccount();
            obj2.GetCuurentAccountDetails();
            decimal Balance = obj2.AccountBalance();
            string atm = obj2.Atm();

            Console.WriteLine("AccountBalance: " + Balance);
            Console.WriteLine("ATM status: " + atm);

            Console.ReadLine();



        }
    }
}

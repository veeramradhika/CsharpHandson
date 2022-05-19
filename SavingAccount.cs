using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankSystem
{
    public class SavingAccount : Account
    {
        public override string AccountName
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public override int AccountNumber
        {
            get => throw new NotImplementedException(); set => throw new NotImplementedException();
        }
        public override decimal AccountBalance()
        {
            return (2000);
        }
        public override string Atm()
        {
            return ("ATM is available");
        }
        public void GetSavingAccountDetails()
        {
            Console.WriteLine("Enter name of the account: ");
            string accountName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the account number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());



        }
    }
}


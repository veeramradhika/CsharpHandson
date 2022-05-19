using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankSystem
{
    public interface IAccount
    {
        string AccontName();
        int AccountNumber();
        decimal AccountBalance();

    }
    interface IAccountTransaction
    {
       int  Transaction();
    }
    public class SalaryAccount : IAccount, IAccountTransaction
    {
        public string AccontName()
        {
            return ("John");
        }

        public decimal AccountBalance()
        {
            return (2000);
        }

        public int AccountNumber()
        {
            return(104345);
        }

        int Transaction()
        {
           return (1000);
        }

        int IAccountTransaction.Transaction()
        {
            return (1000);
        }
    }
}

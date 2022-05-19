using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankSystem
{
    public abstract class Account
    {
        public abstract string AccountName { get; set; }
        public abstract int AccountNumber { get; set; }

        public abstract decimal AccountBalance();
        public virtual string Atm()
        {
            return "ATM is available";
        }

    }
}
    

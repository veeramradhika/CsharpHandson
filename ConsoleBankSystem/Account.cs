using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankSystem
{
    public abstract class Account
    {
        public abstract string AccountName();
        public abstract int AccountNumber();
        public abstract decimal AccountBalance();
        public virtual string ATM()
        {
            return "ATM is available";
        }

    }
}
    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankSystem
{
    public class SavingAccount : Account
    {
            public override string AccountName()
        {
            return ("Latha");
        }
        public override int AccountNumber()
        {
            return (100);
        }
        public override decimal AccountBalance()
        {
            return (2000);
        }
        public override string ATM()
        {
            return ("Yes");
        }
    }
    }


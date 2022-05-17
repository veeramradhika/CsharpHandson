using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Users userobj = new Users(100,"John",1234);
            userobj.GetUserDetails();
            Console.WriteLine("successfully got the user details");
            Console.ReadLine();
        }
    }
}

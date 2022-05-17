using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsObject
{
    internal class Users
    {
        public int id { get; set; }
        public string name { get; set; }
        private int password { get; set; }
        public Users(int Id, string Name, int Password)
        {
            id = Id;
            name = Name;
            password = Password;
        }
        public void GetUserDetails()
        {
            Console.WriteLine("Id: {0}, Name: {1}, password: {2}", id, name, password);
        }
    }
}

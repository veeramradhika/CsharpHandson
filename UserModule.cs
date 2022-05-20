using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BillingAndInventorySystem
{
    internal class UserModule
    {
        public int userid, phone;
        public string fname, lname, email;

        public void WriteFile()
        {
            FileStream userObj = new FileStream(@"C:\TrainingRepo\user.txt", FileMode.Create, FileAccess.Write);
            StreamWriter Writerobj1 = new StreamWriter(userObj);
            Writerobj1.WriteLine("userid\tfname\tlname\temail\tphone\t");

            for (int i = 1; i < 6; i++)
            {


                Console.WriteLine("Enter the userid:");
                userid = Convert.ToInt32(Console.ReadLine());
                Writerobj1.Write(userid + "\t");


                Console.Write("Enter the fname:");
                fname = Convert.ToString(Console.ReadLine());
                Writerobj1.Write(fname + "\t");

                Console.Write("Enter the lname:");
                lname = Convert.ToString(Console.ReadLine());
                Writerobj1.Write(lname + "\t");

                Console.Write("Enter the email:");
                email = Convert.ToString(Console.ReadLine());
                Writerobj1.Write(email + "\t");

                Console.Write("Enter the phone:");
                phone = Convert.ToInt32(Console.ReadLine());
                Writerobj1.Write(phone + "\n");

            }
            Writerobj1.Close();
            userObj.Close();
            Console.WriteLine("user module completed..");
        }
    }
}
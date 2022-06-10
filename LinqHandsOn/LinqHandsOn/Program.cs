using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    public class Program
    {
        static void Main(string[] args)
        {

            Class1 class1 = new Class1();
            //program-1
            class1.Numbers();

            //program-2
            class1.Number_Frequency();

            //program-3
            class1.Char_Frequency();

            //program-4
            class1.Specific_Char();

            ////program-5
            class1.Nth_records();

            //program-9
            class1.PersonOlderThan();

            ////program-10
            class1.CollectionWithL();

            //program-6
            Students stud = new Students();
            stud.MaximumGrade();

            //program-7
            LastName lastName = new LastName();
            lastName.LastNameWithD();

            //program-8
            lastName.NoOfPeople();


            Console.ReadLine();

        }
    }
}

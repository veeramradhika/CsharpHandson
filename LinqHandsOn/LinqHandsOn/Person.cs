using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    public class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public Person(string fname, string lname, int age)
        {
            Fname = fname;
            Lname = lname;
            Age = age;

        }

    }
    public class LastName
    {
        public void LastNameWithD()
        {
            var people = new List<Person>()
            {
             new Person("Bill", "Smith", 41),
             new Person("Sarah", "Jones", 22),
             new Person("Stacy","Baker", 21),
             new Person("Vivianne","Dexter", 19 ),
             new Person("Bob","Smith", 49 ),
             new Person("Brett","Baker", 51 ),
             new Person("Mark","Parker", 19),
             new Person("Alice","Thompson", 18),
             new Person("Evelyn","Thompson", 58 ),
             new Person("Mort","Martin", 58),
             new Person("Eugene","DeLauter", 84 ),
             new Person("Gail","Dawson", 19 ),

            };
            Console.WriteLine("Enter the leter to find the names from the list: ");
            string letter = Console.ReadLine();
            var result = (from n in people
                          where n.Lname.StartsWith(letter)
                          select n.Lname).ToList();
            foreach (var lname in result)
            {
                Console.WriteLine(lname);
            }
        }
        //8.Number of people whose last name starts with the letter D
        public void NoOfPeople()
        {
            var people = new List<Person>()
                {
                 new Person("Bill", "Smith", 41),
                 new Person("Sarah", "Jones", 22),
                 new Person("Stacy","Baker", 21),
                 new Person("Vivianne","Dexter", 19 ),
                 new Person("Bob","Smith", 49 ),
                 new Person("Brett","Baker", 51 ),
                 new Person("Mark","Parker", 19),
                 new Person("Alice","Thompson", 18),
                 new Person("Evelyn","Thompson", 58 ),
                 new Person("Mort","Martin", 58),
                 new Person("Eugene","DeLauter", 84 ),
                 new Person("Gail","Dawson", 19 ),

                };
            Console.WriteLine("Enter the leter to find the Number of people " +
                "whose last name starts with the letter: ");
            string letter = Console.ReadLine();
            var result = (from n in people
                          where n.Lname.StartsWith(letter)
                          select n.Lname).ToList();
            foreach (var lname in result)

                Console.WriteLine(result.Count());

        }
    }   
}




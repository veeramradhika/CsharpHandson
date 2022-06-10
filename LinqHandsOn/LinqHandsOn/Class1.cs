using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;
using System.IO;

namespace LinqHandsOn
{
    public class Class1
    {
        //1.Write a program in C# Sharp to find the positive numbers
        //from a list of numbers using two where conditions in LINQ Query.
       
        public void Numbers()
        {
            //specify the data numbers
            int[] numbers = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //Define the query expression
            IEnumerable<int> numberQuery = from number in numbers
                                          where number >=1
                                          select number;
            //Execute the query
            foreach(int i in numberQuery )
            {
                Console.WriteLine(i + "");
                
            }
            Console.WriteLine("All the positive numbers has been displayed....");
        }

        //2.Write a program in C# Sharp to display the number
        //and frequency of number from given array.
        public void Number_Frequency()
        {
            // specify the data arr1
            int[] arr1 = new int[]
                {5,9,1,2,3,7,5,6,7,3,7,6,8,5,4,9,6,2};
            Console.WriteLine("The numbers in array are: " + "\n" );
            Console.WriteLine("5,9,1,2,3,7,5,6,7,3,7,6,8,5,4,9,6,2");
            //Define the query expression
            var result = from n in arr1
                         group n by n into m
                         select m;
            //Execute the query
            foreach(var x in result)
            {
                Console.WriteLine("Number " + x.Key + " appears " + x.Count() + " times.");
            }


        }
        //3.Write a program in C# Sharp to display the characters
        //and frequency of character from giving string
        public void Char_Frequency()
        {
            string input;
            Console.WriteLine("Enter the input string: ");
            input = Console.ReadLine();
            Console.WriteLine("Input: " + input);
            Console.WriteLine("The frequency of thw characters are: ");

            var result = from n in input
                         group n by n into m
                         select m;
            foreach(var character in result)
            {

                Console.WriteLine("Character " + character.Key + ":" + character.Count() + " times");
            }

        }
        //4.Write a program in C# Sharp to find the string
        //which starts and ends with a specific character
        public void Specific_Char()
        {
            List<string> cities = new List<string>()
                  {
                      "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH",
                "NEWDELHI","AMSTERDAM","ABUDHABI","PARIS"
                  };

            var result = (from city in cities
                          select city).ToList();

            Console.WriteLine("The cities are :");
            foreach (var city in result)
            {
                Console.Write($"{city} ");
            }
            Console.WriteLine();
            Console.Write("Input starting character for the string :");
            string CharStart, CharEnds;
            CharStart = Console.ReadLine();

            Console.Write("Input ending character for the string :");
            CharEnds = Console.ReadLine();

            var resCity = (from city in cities
                           where city.StartsWith(CharStart) && city.EndsWith(CharEnds)
                           select city).FirstOrDefault();

            Console.WriteLine($"The city starting with {CharStart} and ending with {CharEnds} is :{resCity}");


        }
        //5.Write a program in C# Sharp to display the top n-th records.
        public void Nth_records()
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(7);
            list.Add(13);
            list.Add(24);
            list.Add(6);
            list.Add(9);
            list.Add(8);
            list.Add(7);

           
            Console.WriteLine("The menebers of the list are: " );
            Console.WriteLine("5, 7, 13, 24, 6, 9, 8, 7");
            Console.WriteLine("How many records you want display? " );
            int input = Convert.ToInt32(Console.ReadLine());
            list.Sort();
            list.Reverse();
           
            foreach(int topnum in list.Take(input))
            {
                Console.WriteLine("the top {0} records from the list are: {1}", input, topnum);
            }
        }
        //9.Write linq statement for first Person Older Than 40
        //In Descending Alphabetical Order By First Name

        public void PersonOlderThan()
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
           
            var result = (from n in people
                          where n.Age>40
                          select n.Fname).ToList();
            foreach (var fname in result)
            {
                Console.WriteLine(fname);
            }
        }
        //10.Find the words in the collection that start with the letter 'L'
        public void CollectionWithL()
        {
            List<string> fruits = new List<string>() 
            { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            Console.WriteLine("Enter the letter to find the collection of words in list: ");
            string letter = Console.ReadLine();

            var result = from n in fruits
                         where n.StartsWith(letter)
                         select n;
            foreach(var words in result)
            {
                Console.WriteLine(words);
            }
        }
    }

}

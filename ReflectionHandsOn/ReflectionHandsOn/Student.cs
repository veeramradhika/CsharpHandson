using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHandsOn
{
    class Student
    {
        //properities defination
        public int RollNo { get; set; }
        public string Name { get; set; }
        //constructor with no argument
        public Student()
        {
            RollNo = 0;
            Name = String.Empty;
        }
        //constructor with parameters
        public Student(int rollno, string name)
        {
            RollNo = rollno;
            Name = name;
        }
        //method to display student data
        public void DisplayData()
        {
            Console.WriteLine("Roll No: {0}", RollNo);
            Console.WriteLine("Name: {0}", Name);

        }
    }
}

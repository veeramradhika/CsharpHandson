using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqHandsOn
{
    public class Students
    {
        //6.Write a program in C# Sharp to find the n-th Maximum grade point
        //achieved by the students from the list of students.

        public string SName { get; set; }
        public int Sid { get; set; }
        public int gradepoint { get; set; }
        public void MaximumGrade()
        {
            //Students students1 = new Students();
            List<Students> list = new List<Students>();
            list.Add(new Students { Sid = 1, SName = " Joseph ", gradepoint = 800 });
            list.Add(new Students { Sid = 2, SName = " Alex ", gradepoint = 458 });
            list.Add(new Students { Sid = 3, SName = " Harris ", gradepoint = 900 });
            list.Add(new Students { Sid = 4, SName = " Taylor ", gradepoint = 900 });
            list.Add(new Students { Sid = 5, SName = " Smith ", gradepoint = 458 });
            list.Add(new Students { Sid = 6, SName = " Natasa ", gradepoint = 700 });
            list.Add(new Students { Sid = 7, SName = " David ", gradepoint = 750 });
            list.Add(new Students { Sid = 8, SName = " Harry ", gradepoint = 700 });
            list.Add(new Students { Sid = 9, SName = " Nicolash ", gradepoint = 597 });
            list.Add(new Students { Sid = 10, SName = " Jenny ", gradepoint = 750 });
            Console.WriteLine("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : ");
            int grPointRank = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            
            var students = (from stulist in list
                            group stulist by stulist.gradepoint into g
                            orderby g.Key descending
                            select new
                            {
                                StuRecord = g.ToList()
                            }).ToList();

            students[grPointRank - 1].StuRecord
                .ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}", i.Sid, i.SName, i.gradepoint));

            
        }
       
        



    }
}

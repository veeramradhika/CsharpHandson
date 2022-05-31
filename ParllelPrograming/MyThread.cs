using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParllelPrograming
{
    public class MyThread
    {
        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        //public static void Thread2()
        //{
        //    Console.WriteLine("Task one");
        //    Thread.Sleep(1000);
        //}
        //public static void Thread3()
        //    {
        //    Console.WriteLine("Task two");
        //    Thread.Sleep(1000);

        //}
        public static void Thread3()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running..");
        }
    }
}

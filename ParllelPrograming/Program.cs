using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ParllelPrograming
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Thread T = Thread.CurrentThread;
            //T.Name = "This is Main thread";
            //Console.WriteLine(T.Name);

            //Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            //Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
            //t1.Start();
            //t2.Start();
            //try
            //{
            //    //t1.Abort();
            //    t2.Abort();
            //}
            //catch(ThreadAbortException tae)
            //{
            //    Console.WriteLine(tae.ToString());
            //}
            //Console.WriteLine("end of main");


            //Thread t2 = new Thread(new ThreadStart(MyThread.Thread2));
            //Thread t3 = new Thread(new ThreadStart(MyThread.Thread3));
            //t2.Start();
            //t3.Start();


            //Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            //Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
            //Thread t3 = new Thread(new ThreadStart(MyThread.Thread1));
            //t1.Start();
            //t1.Join();
            //t2.Start();
            //t2.Join();
            //t3.Start();
            //t3.Join();



            //Thread t1 = new Thread(new ThreadStart(MyThread.Thread3));
            //Thread t2 = new Thread(new ThreadStart(MyThread.Thread3));
            //Thread t3 = new Thread(new ThreadStart(MyThread.Thread3));
            //t1.Name = "player1";
            //t2.Name = "player2";
            //t3.Name = "player3";
            //t3.Priority = ThreadPriority.Normal;
            //t1.Priority = ThreadPriority.Lowest;
            //t2.Priority = ThreadPriority.Highest;

            //t1.Start();
            //t2.Start();
            //t3.Start();


            TaskParallel taskParallel = new TaskParallel();
            taskParallel.ShowData();
            Console.ReadLine();
        }
    }
}

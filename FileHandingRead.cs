using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilleReadingDemo
{
    public class FileHandingRead
    {
        public void ReadFile()
        {
            FileStream filestreamObj = new FileStream(@"C:\TrainingRepo\Read.txt", FileMode.Open, FileAccess.Read);
            StreamReader readObj = new StreamReader(filestreamObj);
            //readObj.ReadLine()
            Console.WriteLine("Id" + "\t" + "Source" + "\t\t" + "Destination" + "\t" + "Date\t\t" + "Time\t\t" + "Status" + "\t" + "Network");
            while (readObj.Peek() > 0)
            {
                string line = readObj.ReadLine(); 
                if (line != "")
                {
                    string[] myStrs = line.Split(':');
                    if (myStrs[0] == "Date")
                    {

                        string[] dateTime = myStrs[1].Split(' ');
                        Console.Write(dateTime[0] + "\t" + dateTime[1] + ":" + myStrs[2] + ":" + myStrs[3] + "\t");

                    }
                    else
                    {
                        Console.Write(myStrs[1] + "\t");
                    }
                }
                else
                {
                    Console.WriteLine();
                }

            }

            Console.WriteLine("\n" + "Read operation completed");
        }
    }
    }

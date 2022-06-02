using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Reflection
            //Intialize 't' as type of string
            Type t = typeof(string);
            //use reflection to find about any sort of data related to t
            Console.WriteLine("name: {0}", t.Name);
            Console.WriteLine("nameSpace: {0}", t.Namespace);
            Console.WriteLine("FullName: {0}", t.FullName);
            Console.WriteLine("bASETYPE: {0}", t.BaseType);
            Console.ReadLine();

            // Declare Instance of class Assembly
            // Call the GetExecutingAssembly method
            // to load the current assembly
            Assembly executing = Assembly.GetExecutingAssembly();

            // Array to store types of the assembly
            Type[] types = executing.GetTypes();
            foreach (var item in types)
            {
                //display each type
                Console.WriteLine("class: {0}", item.Name);

                MethodInfo[] methods = item.GetMethods();
                foreach (var method in methods)
                {
                    Console.WriteLine("Methods: {0}", method.Name);

                    // Array to store parameters
                    ParameterInfo[] parameters = method.GetParameters();
                    foreach (var arg in parameters)
                    {
                        Console.WriteLine("Parameters: {0} Type : {1}", arg.Name, arg.ParameterType);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

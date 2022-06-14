using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AdoDotNetHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeData employeeData = new EmployeeData();

            employeeData.insertEmployee();             //insert employee records

            employeeData.UpdateEmployee();           //update record

            Console.WriteLine("Enter the EmpId to delete: ");   // delete record
            int EmpId=Convert.ToInt32(Console.ReadLine());
            employeeData.DeleteEmployee(EmpId);

            DataTable dt = employeeData.SelectEmployees(); //select all the employee records
            for (int i = 0; i < dt.Rows.Count; i++) //row iteration
            {
                for (int j = 0; j < dt.Columns.Count; j++) //column iteration
               {
                  Console.Write(dt.Rows[i][j] + "\t\t");
               }
           Console.WriteLine();
           }

            Console.WriteLine("Enter the EmpId to Select Employee: "); // select employee records by empid
            int Empid = Convert.ToInt32(Console.ReadLine());
            DataTable dt = employeeData.SelectEmployeeById(Empid);
            for (int i = 0; i < dt.Rows.Count; i++) //row iteration
            {
                for (int j = 0; j < dt.Columns.Count; j++) //column iteration
                {
                    Console.Write(dt.Rows[i][j] + "\t\t");
                }
                //Console.WriteLine();
            }

            //account instance
            AccountData accountData = new AccountData();

            accountData.insertAccount();          //insert account records

            accountData.updateAccount();            //update account records

            Console.WriteLine("Enter the Account Id to delete: ");  //delete account records
            int ActId = Convert.ToInt32(Console.ReadLine());
            accountData.DeleteAccount(ActId);


            DataTable dt = accountData.SelectAccounts();   //select all account records
            for (int i = 0; i < dt.Rows.Count; i++) //row iteration
            {
                for (int j = 0; j < dt.Columns.Count; j++) //column iteration
                {
                    Console.Write(dt.Rows[i][j] + "\t\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Enter the Account Id to Select Account: ");  //select account records by Act Id
            int Actid = Convert.ToInt32(Console.ReadLine());
            DataTable dt = accountData.SelectAccountById(Actid);
            for (int i = 0; i < dt.Rows.Count; i++) //row iteration
            {
                for (int j = 0; j < dt.Columns.Count; j++) //column iteration
                {
                    Console.Write(dt.Rows[i][j] + "\t\t");
                }
                Console.WriteLine();

                Console.ReadLine();
            }
        }
    }
}


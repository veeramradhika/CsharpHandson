using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoDotNetHandsOn
{
    public class EmployeeData
    {
        public static string sqlConnectionStr = "Data Source=RADHIKA;Initial Catalog = BankDb; Integrated Security = True";
        public string insertEmployee()
        {
            Console.WriteLine("Enter the Emp Id: ");
            int empId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Emp Name: ");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter the Emp Mobile: ");
            decimal empMobile = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the Emp address: ");
            string empAddress = Console.ReadLine();

            //inserting the values into the sql
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("insert into Employee values("+empId+",'"+empName+"',"+empMobile+",'"+empAddress+"')",sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "values are inserted";
        }
    }
}

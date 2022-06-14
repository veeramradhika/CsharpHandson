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
        public string UpdateEmployee()
        {
            Console.WriteLine("Enter the Emp Id to update: ");
            int empId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Emp Name to update: ");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter the Emp Mobile to update: ");
            decimal empMobile = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the Emp address to update: ");
            string empAddress = Console.ReadLine();


            //insert customer data into sqlserver
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("update Employee set EmpName='" + empName + "' , EmpMobile='" + empMobile + "' , EmpAddress='" + empAddress + "' where EmpId="+empId+ "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";
        }
        public string DeleteEmployee(int EmpId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("delete from Employee where EmpId=" + EmpId, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
        }
        public DataTable SelectEmployees()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Employee", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
             dataTable.Load(dataReader);
            //DataTable--to store the records in table format
            sqlConnection.Close(); //connection state is close
            //if (result == 0)
            //    return "dataTable is empty";
                return dataTable;
        }
        public DataTable SelectEmployeeById(int EmpId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Employee where EmpId=" + EmpId, sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            //DataTable, DataSet
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }
       
    }
    

}

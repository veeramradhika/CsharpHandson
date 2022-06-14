using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AdoDotNetHandsOn
{
    public class AccountData
    {
        public static string sqlConnectionStr = "Data Source=RADHIKA;Initial Catalog = BankDb; Integrated Security = True";
        public string insertAccount()
        {
            Console.WriteLine("Enter the Account Id: ");
            int ActId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Account Number: ");
            Double ActNo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Account type: ");
            string ActType = Console.ReadLine();

            Console.WriteLine("Enter the Account status: ");
            string ActStatus = Console.ReadLine();



            //inserting the values into the sql
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);
            SqlCommand cmd = new SqlCommand("insert into Account values("+ActId+","+ActNo+",'"+ActType+"','"+ActStatus+"')", sqlConnection);
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
            return "inserted";
        }
        public string updateAccount()
        {
            Console.WriteLine("Enter the Account Id to update: ");
            int ActId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Account Number to updat: ");
            Double ActNo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Account type to updat: ");
            string ActType = Console.ReadLine();

            Console.WriteLine("Enter the Account status to updat: ");
            string ActStatus = Console.ReadLine();

            //updating the values into the sql
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("update Account set ActNo=" + ActNo + " , ActType='" + ActType + "' , ActStatus='" + ActStatus + "'  where ActId=" + ActId + "", sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Updated";
            return "Updated";

        }
        public string DeleteAccount(int ActId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            SqlCommand cmd = new SqlCommand("delete from Account where ActId=" + ActId, sqlConnection);
            sqlConnection.Open();//connection state is open
            int result = cmd.ExecuteNonQuery();//execute my sql commands 1
            sqlConnection.Close(); //connection state is close
            if (result == 0)
                return "Not Deleted";
            return "Deleted";
        }
        public DataTable SelectAccounts()
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Account", sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
            //DataTable, DataSet
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }
        public DataTable SelectAccountById(int ActId)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionStr);//connection establishment
            string db = sqlConnection.Database;
            SqlCommand cmd = new SqlCommand("select * from Account where ActId=" + ActId, sqlConnection);
            sqlConnection.Open();//connection state is open
            SqlDataReader dataReader = cmd.ExecuteReader();//execute select statment
            DataTable dataTable = new DataTable();
            dataTable.Load(dataReader);
           
            sqlConnection.Close(); //connection state is close
            return dataTable;
        }
    }
}

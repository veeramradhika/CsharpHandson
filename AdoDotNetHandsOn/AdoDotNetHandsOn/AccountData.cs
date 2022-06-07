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
    }
}

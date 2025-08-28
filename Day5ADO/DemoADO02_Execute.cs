using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ADO
{
    internal class DemoADO02_Execute
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=0FFB3AAAED63595\\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True;Trust Server Certificate=True";
            connection.Open();
            Console.WriteLine("Connected to SQL Server");
            Console.WriteLine(connection.State);

            // Step 2  - Command
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Update Products Set ProductName ='A Product' where ProductId=13";

            int updatedCount = command.ExecuteNonQuery();
            Console.WriteLine($"{updatedCount} records effected");

        }
    }
}

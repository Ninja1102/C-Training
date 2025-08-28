using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5ADO
{
    internal class DemoADO03_DataSet
    {
        static void Main(string[] args)
        {

            // Step1 - Connection
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=0FFB3AAAED63595\\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True;Trust Server Certificate=True";
            Console.WriteLine("Connected to SQL Server");
            Console.WriteLine(connection.State);

            // Step 2  - Command
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "Select ProductId, ProductName from Products order by ProductId";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "TempProd");

            Console.WriteLine(dataSet.Tables[0].Rows.Count);

            Console.WriteLine(dataSet.Tables[0].Rows[1][1]);

            dataSet.Tables[0].Rows[0][1] = "Updated Chai";
            dataSet.Tables[0].Rows[1][1] = "Updated Chang";

            adapter.Update(dataSet.Tables[0]);

        }
    }
}

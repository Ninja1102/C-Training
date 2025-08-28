using Microsoft.Data.SqlClient;

namespace Day5ADO
{
    internal class DemoADO01_Reader
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = "Data Source=0FFB3AAAED63595\\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True;Trust Server Certificate=True";
                connection.Open();
                Console.WriteLine("Connected to SQL Server");

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT ProductID, ProductName FROM Products WHERE ProductID < 11";

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) 
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0] + " " + reader[1]);
                    }
                }
                else
                {
                    Console.WriteLine("No data available for query");
                }

                Console.WriteLine("All Data shown");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

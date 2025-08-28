namespace Day4Adv
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }


    internal class Assignment6
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{Id = 1, Name = "EMP1", Department = "D1", Salary = 20000 },
                new Employee{Id = 2, Name = "EMP2", Department = "D3", Salary = 29000 },
                new Employee{Id = 3, Name = "EMP3", Department = "D3", Salary = 30000 },
                new Employee{Id = 4, Name = "EMP4", Department = "D2", Salary = 25000 },
                new Employee{Id = 5, Name = "EMP5", Department = "D1", Salary = 50000 },

            };

            Console.WriteLine("Display all employees");
            foreach(var emp in employees)
            {
                Console.WriteLine($"{emp.Id}. {emp.Name}, {emp.Department}, {emp.Salary}");
            }

            Console.WriteLine("\nFilter employees by department");
            var result1 = employees.Where(e => e.Department == "D1");
            foreach (var emp in result1)
            {
                Console.WriteLine($"{emp.Id}. {emp.Name}, {emp.Department}, {emp.Salary}");
            }

            Console.WriteLine("\nSort employees by salary (ascending)");
            var result2 = employees.OrderBy(e => e.Salary);
            foreach (var emp in result2)
            {
                Console.WriteLine($"{emp.Id}. {emp.Name}, {emp.Department}, {emp.Salary}");
            }

            Console.WriteLine("\nSort employees by salary (descending)");
            var result3 = employees.OrderByDescending(e => e.Salary);
            foreach (var emp in result3)
            {
                Console.WriteLine($"{emp.Id}. {emp.Name}, {emp.Department}, {emp.Salary}");
            }

            Console.WriteLine("\nGroup employees by department");
            var result4 = employees.GroupBy(e => e.Department);
            foreach(var emp in result4)
            {
                Console.WriteLine(emp.Key);
                foreach (var item in emp)
                {
                    Console.WriteLine($"\t{item.Id}. {item.Name}, {item.Department}, {item.Salary}");

                }
            }

            Console.WriteLine("\nEmployee with the highest salary");
            var result5 = employees.MaxBy(e => e.Salary);
            if(result5 != null)
            {
                Console.WriteLine($"{result5.Id}. {result5.Name}, {result5.Department}, {result5.Salary}");
            }

            Console.WriteLine("\nAverage salary of all employees");
            var result6 = employees.Average(e => e.Salary);
            Console.WriteLine(result6);

            Console.WriteLine("\nFilter employees by salary range");
            var result7 = employees.Where(e => e.Salary >= 25000 && e.Salary <= 40000);
            foreach (var emp in result7)
            {
                Console.WriteLine($"{emp.Id}. {emp.Name}, {emp.Department}, {emp.Salary}");
            }
        }
    }
}

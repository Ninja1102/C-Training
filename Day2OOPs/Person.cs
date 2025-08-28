namespace Day2OOPs
{
    internal class Person 
    {

        public Person()
        {
            Id = 111;
            Name = "Hari";
            City = "PY";
        }

        public Person(int id, string name, string city)
        {
            Id = id;
            Name = name;
            City = city;
        }

        //Properties
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Wrong name");
                }
            }
        }
        //data members - Feilds - should not be public
        private int id;

        //fully implemented property
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    Console.WriteLine("Wrong id");
                }
            }
        }

        public string City { get; set; }


        //methods - behaviour members
        //public void Display()
        //{
        //    Console.WriteLine($"Id - {Id} Name - {Name} - City - {City}");
        //}

        public override string ToString()
        {
            return $"Id - {Id} - Name - {Name} - City - {City}";
        }
    }

    class Student : Person
    {

        public Student(int id, string name, string city, string standard) : base(id, name, city)
        {
            Standard = standard;            
        }

        public string Standard { get; set; }


        public override string ToString()
        {
            return base.ToString() + $" - Standard - {Standard}";
        }
    }

    class UserPersonClass
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student(0, "", "Trichy", "X");
            //Console.WriteLine(person1);
            //person1.Id = 1;
            //person1.Name = "Hari";
            //person1.City = "PY";
            //Console.WriteLine(person1.Name);
            //person1.Display();
            //Console.WriteLine(person1);


            Student student = new Student(1235, "Shiva", "Chennai", "IX");
            Console.WriteLine(student);
        }
    }
}

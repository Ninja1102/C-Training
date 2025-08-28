namespace Day4Adv
{

    delegate void AppraisalDelegate();

    class Employee1()
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public event AppraisalDelegate Appraisal;

        public void OnAppraisal()
        {
            Appraisal();
        }
    }
    internal class EventDemo
    {
        static void Main(string[] args)
        {
            static void ThisYearAppraisal()
            {
                Console.WriteLine("Decided for 25% Appraisal");
            }

            Employee1 emp1 = new Employee1() { Name = "Emp1"};
            Employee1 emp2 = new Employee1() { Id = 1 };
            Employee1 emp3 = new Employee1() { Id = 2, Name = "Emp3"};

            emp1.Appraisal += ThisYearAppraisal; //binding to event handler

            emp1.OnAppraisal();

        }
    }
}

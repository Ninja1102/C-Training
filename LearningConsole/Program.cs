using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //short s1 = 133;
            //long l1 = 45678;

            int age1 = 25;
            int age2 = age1;
            Console.WriteLine(age1);
            Console.WriteLine(age2);

            age1 = 35;
            Console.WriteLine(age1);
            Console.WriteLine(age2);

        }
    }
}

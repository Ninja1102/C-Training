using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningConsole
{
    internal class DemoConstructs
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Demo on Constructs");

            ////entry from console
            //Console.Write("Enter your Name: ");
            //string name = Console.ReadLine();

            //Console.Write("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your Salary: ");
            //double salary = double.Parse(Console.ReadLine());

            //Console.WriteLine("Your Name is " + name + " and your age is " + age + " Salary "+salary);
            //Console.WriteLine("Your Name is {0} and your age is {1} salary - {2}", name, age, salary);

            ////inter polation
            //Console.WriteLine($"Your Name is {name} and your age is {age} salary {salary:0.00}");

            //Console.WriteLine("Your Name is " + name);
            //Console.WriteLine("Your age is " + age);


            //int num = 12;
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{num, 3} x {i,3} = {num*i, 4}");
            //}

            //int[] arr1 = new int[5];
            int[] arr2 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(string.Join(",", arr2));

            //Console.WriteLine(arr2[3]);
            //Console.WriteLine(arr1[3]);

            int[,] arr3 = new int[3, 4];
            int[,] arr4 =
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8 },
                {9, 10, 11, 12 }
            };

            for (int row = 0; row < arr4.GetLength(0); row++)
            {
                for (int col = 0; col < arr4.GetLength(1); col++)
                {
                    Console.Write($"{arr4[row, col]} ", 4);
                }
                Console.WriteLine();
            }
        }
    }
}

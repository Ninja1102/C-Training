using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningConsole
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of subjects: ");
            int n_sub = int.Parse(Console.ReadLine());

            int[] marks = new int[n_sub];

            for (int i = 0; i < n_sub; i++)
            {
                Console.Write($"Enter the score for subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            Console.WriteLine($"Average Score: {CalculateAverage(marks): 0.00}");
            Console.WriteLine($"Grade: {DetermineGrade(CalculateAverage(marks))}");

            int[] arr = HighestLowestScores(marks);
            Console.WriteLine($"Highest Mark: {arr[0]}");
            Console.WriteLine($"Lowest Mark: {arr[1]}");
        }

        static double CalculateAverage(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum / arr.Length;
        }

        static string DetermineGrade(double avg)
        {
            if(avg >= 90)
            {
                return "A";
            }
            else if(avg >= 80)
            {
                return "B";
            }
            else if(avg >= 70)
            {
                return "C";
            }
            else if (avg >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static int[] HighestLowestScores(int[] arr)
        {
            int highest = arr[0];
            int lowest = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if(highest < arr[i])
                {
                    highest = arr[i];
                }
                if(lowest > arr[i])
                {
                    lowest = arr[i];
                }
            }
            return new int[] { highest, lowest };
        }
    }
}

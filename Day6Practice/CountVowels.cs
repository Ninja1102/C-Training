using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Practice
{
    internal class CountVowels
    {
        static void Main(string[] args)
        {
            string Vowels = "aeiouAEIOU";
            string testStr = "Haripriya";
            int count = 0;

            foreach(char c in testStr)
            {
                if (Vowels.Contains(c))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

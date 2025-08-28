using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Practice
{
    internal class CountWords
    {
        static void Main(string[] args)
        {
            string s = "   David This is sentence Haripriya   ";
            Console.WriteLine(Count(s));
        }

        public static int Count(string str)
        {
            string[] strArr = str.Trim().Split(" ");
            return strArr.Length;
        }
    }
}

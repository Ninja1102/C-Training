using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Practice
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            string str = "Hello";

            //string val = new string(str.Reverse().ToArray());
            //Console.WriteLine(val);

            Console.WriteLine(RevStr(str));
        }

        public static string RevStr(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            String res = new String(chars);
            return res;
        }
    }
}

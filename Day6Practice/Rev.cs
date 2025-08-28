using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Practice
{
    internal class Rev
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RevStr("Haripriya"));
            
        }

        public static string RevStr(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            //string s = new string(chars);
            string s = string.Join("",chars);
            return s;
        }
    }
}

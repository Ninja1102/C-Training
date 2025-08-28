using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Practice
{
    internal class FindDuplicates
    {
        static void Main(string[] args)
        {
            string s = "HaripriyaMurugavel";
            char[] chars = Duplicates(s);
            foreach(char c in chars)
            {
                Console.Write(c);
            }
        }

        public static char[] Duplicates(string str)
        {
            HashSet<char> chars = new HashSet<char>();
            char[] ch = new char[str.Length];

            int j = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (!chars.Contains(str[i]))
                {
                    chars.Add(str[i]);
                }
                else
                {
                    ch[j] = str[i];
                    j++;
                }
            }
            return ch;
        }
    }
}

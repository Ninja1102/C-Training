using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Practice
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GenerateFact(10));
            string s = "i love cats cats";
            string word = " ";
            string rep = "";
            Console.WriteLine(ReplaceWords(s, word, rep));
        }

        public static int GenerateFact(int n)
        {
            if(n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                int tot = 1;
                for(int i = 1; i <= n; i++)
                {
                    tot *= i;
                }
                return tot;
            }
        }

        public static string ReplaceWords(string str, string oldWord, string newWord)
        {
            if (!str.Contains(oldWord))
            {
                return str;
            } 
            else
            {
                string res = str.Replace(oldWord, newWord);
                return res;
            }
        }
    }
}

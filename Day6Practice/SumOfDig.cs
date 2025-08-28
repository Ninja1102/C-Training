using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Practice
{
    internal class SumOfDig
    {
        static void Main(string[] args)
        {
            int n = 12345;
            Console.WriteLine(SumDig(n));
        }

        public static int SumDig(int n)
        {
            int tot = 0;
            //while (n > 0)
            //{
            //    tot += n % 10;
            //    n /= 10;
            //}

            string str = $"{n}";
            for(int i = 0; i < str.Length; i++)
            {
                tot += int.Parse(str[i].ToString());
            }
            return tot;
        }
    }
}

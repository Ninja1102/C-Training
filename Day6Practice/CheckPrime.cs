using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Practice
{
    internal class CheckPrime
    {
        static void Main(string[] args)
        {
            bool res = PrimeCheck(10);
            Console.WriteLine(res);
        }

        public static bool PrimeCheck(int n)
        {
            if(n <= 1)
            {
                return false;
            }
            if (n == 2) 
            {
                return true;
            }

            for(int i = 3; i < Math.Sqrt(n); i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

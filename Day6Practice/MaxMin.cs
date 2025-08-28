using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Practice
{
    internal class MaxMin
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] res = MaxMinNum(arr);
            for(int i=0; i<res.Length; i++)
            {
                Console.Write(res[i]+ " ");
            }
            Console.WriteLine($"\n[ {string.Join(", ",res)} ]");
            //[10,1]
        }

        public static int[] MaxMinNum(int[] arr)
        {
            int max = arr.Max();
            int min = arr.Min();

            return new int[] { max, min }; // [10,1]
        }
    }
}

namespace Day6Practice
{
    internal class Sort
    {
        static void Main(string[] args)
        {
            int[] n = { 2, 5, 16, 11, 40 };
            int[] res = SortArr(n);
            Console.WriteLine(string.Join(", ", res));
        }
         public static int[] SortArr(int[] arr)
        {
            Array.Sort(arr);
            //Array.Reverse(arr);
            return arr;
        }
    }
}

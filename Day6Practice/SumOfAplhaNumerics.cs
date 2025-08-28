namespace Day6Practice
{
    internal class SumOfAplhaNumerics
    {
        static void Main(string[] args)
        {
            string str = "a1b2c3d4";
            Console.WriteLine(SumOfNumbers(str));

        }
        public static string SumOfNumbers(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    sum += int.Parse(str[i].ToString());
                }
            }
            return sum.ToString();
        }
    }
}

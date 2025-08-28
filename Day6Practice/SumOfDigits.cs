namespace Day6Practice
{
    internal class SumOfDigits
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitsSum(12345));
            
        }

        public static int DigitsSum(int n) 
        {
            string s = $"{n}";
            char[] chars = s.ToCharArray();
            int total = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                //total += chars[i] - '0';
                total += int.Parse(chars[i].ToString());
            }
            return total;
        }
    }

}

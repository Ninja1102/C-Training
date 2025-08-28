namespace Day6Practice
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalindromeChecker("Malayalam"));
        }

        public static bool PalindromeChecker(string str)
        {
            string s = str;
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            string s1 = new string(chars);
            return s.ToLower() == s1.ToLower();
        }
    }
}

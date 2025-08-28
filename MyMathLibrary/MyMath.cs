namespace MyMathLibrary
{
    public class MyMath
    {
        public static int Add(params int[] arr) 
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        [Obsolete("Better use SubtractNew")]
        public static int Subtract(int a, int b)
        {
            return a-b;
        }

        public static int SubtractNew (int a, int b)
        {
            return a-b;
        }
    }
}

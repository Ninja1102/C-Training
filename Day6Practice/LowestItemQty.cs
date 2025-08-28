namespace Day6Practice
{
    internal class LowestItemQty
    {
        static void Main(string[] args)
        {
            string item = "TV 20, Fridge 4, Box 5";

            string[] arr = item.Split(", ");

            int[] count = new int[arr.Length];

            for(int i =0; i < arr.Length; i++)
            {
                string[] val = arr[i].Split(" ");
                count[i] = int.Parse(val[1]);
            }
            int min = count[0];
            for(int j = 0; j < count.Length; j++)
            {
                if(count[j] < min)
                {
                    min = count[j];
                }
            }

            Console.WriteLine(min);
        }
    }
}

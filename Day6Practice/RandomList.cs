namespace Day6Practice
{
    internal class RandomList
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            HashSet<int> set = new HashSet<int>();

            for(int i=0; i<= 10; i++)
            {
                set.Add(random.Next(1,100));
            }

            for (int i = 0; i <= 10; i++)
            {
                list.Add(random.Next(1, 100));
            }

            foreach (int i in set)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            foreach (int i in list)
            {
                Console.Write(i+ " ");
            }
        }
    }
}

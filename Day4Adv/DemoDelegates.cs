namespace Day4Adv
{
    delegate void MyDelegate();
    internal class DemoDelegates
    {
        static void Show1()
        {
            Console.WriteLine("Show1");
        }

        static void Show2()
        {
            Console.WriteLine("Show2");
        }


        static void Main(string[] args)
        {
            //MyDelegate del1 = Show1;
            //del1();

            //Console.WriteLine();

            //del1 += Show2; // multicasting
            //del1();

            //Console.WriteLine();

            //del1 -= Show1;
            //del1();



        }
    }
}

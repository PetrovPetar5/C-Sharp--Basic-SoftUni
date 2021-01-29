namespace NumbersEdingAt7
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 1000; counter++)
            {
                if (counter % 10 == 7)
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}

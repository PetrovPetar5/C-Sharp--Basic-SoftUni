namespace SumNumbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = 0;
            for (int counter = 0; counter < input; counter++)
            {
                int nextnumber = int.Parse(Console.ReadLine());
                number += nextnumber;
            }

            Console.WriteLine(number);
        }
    }
}

namespace Histogram
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numbersInput = int.Parse(Console.ReadLine());
            double groupP1 = 0;
            double groupP2 = 0;
            double groupP3 = 0;
            double groupP4 = 0;
            double groupP5 = 0;
            for (int counter = 0; counter < numbersInput; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < 200)
                {
                    groupP1++;
                }
                else if (200 <= currentNumber && currentNumber <= 399)
                {
                    groupP2++;
                }
                else if (400 <= currentNumber && currentNumber <= 599)
                {
                    groupP3++;
                }
                else if (600 <= currentNumber && currentNumber <= 799)
                {
                    groupP4++;
                }
                else
                {
                    groupP5++;
                }
            }

            Console.WriteLine($"{(groupP1 / numbersInput * 100):F2}%");
            Console.WriteLine($"{(groupP2 / numbersInput * 100):F2}%");
            Console.WriteLine($"{(groupP3 / numbersInput * 100):F2}%");
            Console.WriteLine($"{(groupP4 / numbersInput * 100):F2}%");
            Console.WriteLine($"{(groupP5 / numbersInput * 100):F2}%");
        }
    }
}

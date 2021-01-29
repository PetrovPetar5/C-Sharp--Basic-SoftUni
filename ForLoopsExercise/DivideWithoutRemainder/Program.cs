namespace DivideWithoutRemainder
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            double grouP1 = 0;
            double grouP2 = 0;
            double grouP3 = 0;
            for (int counter = 0; counter < numberInput; counter++)
            {
                int currenNumber = int.Parse(Console.ReadLine());
                if (currenNumber % 2 == 0)
                {
                    grouP1++;
                }

                if (currenNumber % 3 == 0)
                {
                    grouP2++;
                }

                if (currenNumber % 4 == 0)
                {
                    grouP3++;
                }
            }

            Console.WriteLine($"{grouP1 / numberInput * 100:F2}%");
            Console.WriteLine($"{grouP2 / numberInput * 100:F2}%");
            Console.WriteLine($"{grouP3 / numberInput * 100:F2}%");
        }
    }
}

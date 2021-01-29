namespace LeftAndRightTotal
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            int lefTotal = 0;
            int RighTotal = 0;
            for (int counter = 0; counter < inputNumbers; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                lefTotal += currentNumber;
            }

            for (int counter = 0; counter < inputNumbers; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                RighTotal += currentNumber;
            }

            int difference = Math.Abs(lefTotal - RighTotal);
            if (lefTotal == RighTotal)
            {
                Console.WriteLine($"Yes, sum =" + " " + lefTotal);
            }
            else
            {
                Console.WriteLine("No, diff =" + " " + difference);
            }
        }
    }
}


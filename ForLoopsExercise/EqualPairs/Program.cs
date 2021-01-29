namespace EqualPairs
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int firstInputTotalSumOFBothNumbers = firstNumber + secondNumber;
            int secondInputTotalSumOFBothNumbers = 0;
            int maxDifference = int.MinValue;
            int difference = 0;
            for (int counter = 2; counter <= numbers; counter++)
            {
                firstNumber = int.Parse(Console.ReadLine());
                secondNumber = int.Parse(Console.ReadLine());
                secondInputTotalSumOFBothNumbers = firstNumber + secondNumber;
                if (secondInputTotalSumOFBothNumbers == firstInputTotalSumOFBothNumbers)
                {
                    firstInputTotalSumOFBothNumbers = secondInputTotalSumOFBothNumbers;
                }
                else
                {
                    difference = Math.Abs(secondInputTotalSumOFBothNumbers - firstInputTotalSumOFBothNumbers);
                    if (difference > maxDifference)
                    {
                        maxDifference = difference;
                    }

                    if (counter == numbers)
                    {
                        break;
                    }
                    else
                    {
                        firstInputTotalSumOFBothNumbers = secondInputTotalSumOFBothNumbers;
                    }
                }
            }

            if (numbers == 1)
            {
                Console.WriteLine($"Yes, value={firstInputTotalSumOFBothNumbers}");
            }
            else if (firstInputTotalSumOFBothNumbers == secondInputTotalSumOFBothNumbers && secondInputTotalSumOFBothNumbers != 0)
            {
                Console.WriteLine($"Yes, value={firstInputTotalSumOFBothNumbers}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={difference}");
            }
        }
    }
}

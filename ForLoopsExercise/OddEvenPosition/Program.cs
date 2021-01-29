namespace OddEvenPosition
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = int.MaxValue;
            double oddMax = int.MinValue;
            double evenSum = 0;
            double evenMin = int.MaxValue;
            double evenMax = int.MinValue;
            for (int counter = 0; counter < inputNumbers; counter++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if ((counter + 1) % 2 != 0)
                {
                    oddSum += currentNumber;
                    if (currentNumber < oddMin)
                    {
                        oddMin = currentNumber;
                    }

                    if (currentNumber > oddMax)
                    {
                        oddMax = currentNumber;
                    }
                }
                else
                {
                    evenSum += currentNumber;
                    if (currentNumber < evenMin)
                    {
                        evenMin = currentNumber;
                    }

                    if (currentNumber > evenMax)
                    {
                        evenMax = currentNumber;
                    }
                }
            }

            Console.WriteLine("OddSum=" + "{0:F2},", oddSum);
            if (oddSum == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine("OddMin=" + "{0:F2},", oddMin);
                Console.WriteLine("OddMax=" + "{0:F2},", oddMax);
            }

            Console.WriteLine("EvenSum=" + "{0:F2},", evenSum);
            if (evenSum == 0)
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("EvenMin=" + "{0:F2},", evenMin);
                Console.WriteLine("EvenMax=" + "{0:F2}", evenMax);
            }
        }
    }
}

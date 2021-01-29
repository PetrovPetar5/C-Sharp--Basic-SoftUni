namespace HalfSumElement
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int biggestInput = int.MinValue;
            int inpuTotal = 0;
            for (int counter = 0; counter < number; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                inpuTotal += currentNumber;
                if (currentNumber > biggestInput)
                {
                    biggestInput = currentNumber;
                }
            }
            int lowerInputTotal = inpuTotal - biggestInput;
            int difference = Math.Abs(biggestInput - lowerInputTotal);
            if (biggestInput - lowerInputTotal == 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggestInput}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", difference);
            }
        }
    }
}

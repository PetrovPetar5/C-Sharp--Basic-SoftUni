namespace NumberSequence
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            int maxInput = int.MinValue;
            int minInput = int.MaxValue;
            for (int counter = 0; counter < inputNumbers; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > maxInput)
                {
                    maxInput = currentNumber;
                }
                if (minInput > currentNumber)
                {
                    minInput = currentNumber;
                }
            }

            Console.WriteLine($"Max number: { maxInput}");
            Console.WriteLine($"Min number: {minInput}");
        }
    }
}

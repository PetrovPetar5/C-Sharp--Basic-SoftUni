namespace TwoNumbersSum
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationC = 0;
            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    combinationC++;
                    if (a + b == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationC} ({a} + {b} = {magicNumber})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinationC} combinations - neither equals {magicNumber}");
        }
    }
}

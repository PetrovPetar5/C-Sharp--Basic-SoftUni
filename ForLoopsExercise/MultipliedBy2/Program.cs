namespace MultipliedBy2
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter < 2145454545; counter++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber < 0)
                {
                    Console.WriteLine("Negative number!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Result: {currentNumber * 2:F2}");
                }
            }
        }
    }
}

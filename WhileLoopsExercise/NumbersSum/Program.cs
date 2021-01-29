namespace NumbersSum
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputSum = 0;
            while (input != "Stop")
            {
                int currentNumber = int.Parse(input);
                inputSum += currentNumber;
                input = Console.ReadLine();
            }

            Console.WriteLine($"{inputSum}");
        }
    }
}

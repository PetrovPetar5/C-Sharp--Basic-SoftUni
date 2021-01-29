namespace BankAccount
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numberDebits = int.Parse(Console.ReadLine());
            int counter = 0;
            decimal totalBalance = 0;
            while (counter < numberDebits)
            {
                decimal currentDebit = decimal.Parse(Console.ReadLine());
                if (currentDebit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    totalBalance += currentDebit;
                    Console.WriteLine($"Increase: {currentDebit:f2}");
                }

                counter++;
            }

            Console.WriteLine($"Total: {totalBalance:F2}");
        }
    }
}

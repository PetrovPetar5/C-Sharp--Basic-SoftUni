namespace Travelling
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double moneyNeeded = 0;
            while (input != "End")
            {
                moneyNeeded = double.Parse(Console.ReadLine());
                double currentAmount = 0;
                double moneySaved = 0;
                while (moneyNeeded > moneySaved)
                {
                    currentAmount = double.Parse(Console.ReadLine());
                    moneySaved += currentAmount;
                }

                Console.WriteLine($"Going to {input}!");
                input = Console.ReadLine();
            }
        }
    }
}

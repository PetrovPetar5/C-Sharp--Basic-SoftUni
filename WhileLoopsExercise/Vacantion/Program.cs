namespace Vacantion
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneySaved = double.Parse(Console.ReadLine());
            bool fiveSpendInRow = false;
            int spendInRowCounter = 0;
            int daysCounter = 0;
            while (!fiveSpendInRow && moneySaved < moneyNeeded)
            {
                string action = Console.ReadLine();
                double currentSum = double.Parse(Console.ReadLine());
                if (action == "save")
                {
                    moneySaved += currentSum;
                    spendInRowCounter = 0;
                    daysCounter++;
                }
                else
                {
                    spendInRowCounter++;
                    moneySaved -= currentSum;
                    if (moneySaved < 0)
                    {
                        moneySaved = 0;
                    }

                    if (spendInRowCounter >= 5)
                    {
                        fiveSpendInRow = true;
                    }

                    daysCounter++;
                }
            }

            if (fiveSpendInRow)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}


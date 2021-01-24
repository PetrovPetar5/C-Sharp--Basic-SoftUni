namespace GodzilaVSKong
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            decimal movieBudget = decimal.Parse(Console.ReadLine());
            int extraMen = int.Parse(Console.ReadLine());
            decimal extrasCostumPrice = decimal.Parse(Console.ReadLine());
            decimal decorExpense = movieBudget * 0.10m;
            decimal costumesTotal = extraMen * extrasCostumPrice;
            if (extraMen >= 150)
            {
                costumesTotal *= 0.90m;
            }

            decimal totalCosts = costumesTotal + decorExpense;
            decimal money = Math.Abs(movieBudget - decorExpense - costumesTotal);
            if (totalCosts > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {money:F2} leva more.");
            }
            else if (movieBudget >= totalCosts)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {money:F2} leva left.");
            }
        }
    }
}

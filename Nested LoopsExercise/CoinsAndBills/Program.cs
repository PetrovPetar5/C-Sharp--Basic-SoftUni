namespace CoinsAndBills
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int coinsLev = int.Parse(Console.ReadLine());
            int coinsTwoLevs = int.Parse(Console.ReadLine());
            int billFive = int.Parse(Console.ReadLine());
            int sumFigure = int.Parse(Console.ReadLine());
            for (int a = 0; a <= coinsLev; a++)
            {
                for (int b = 0; b <= coinsTwoLevs; b++)
                {
                    for (int c = 0; c <= billFive; c++)
                    {
                        int total = a * 1 + b * 2 + c * 5;
                        if (total == sumFigure)
                        {
                            Console.WriteLine($"{a} * 1 lv. + {b} * 2 lv. + {c} * 5 lv. = {total} lv.");
                        }
                    }
                }
            }
        }
    }
}

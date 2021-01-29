namespace LuckyNumbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    if (number % (a + b) != 0)
                    {
                        continue;
                    }
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if ((a + b) == (c + d))
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                            }
                        }
                    }
                }
            }
        }
    }
}

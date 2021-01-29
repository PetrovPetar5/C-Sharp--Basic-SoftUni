namespace UniquePin
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number1Limit = int.Parse(Console.ReadLine());
            int number2Limit = int.Parse(Console.ReadLine());
            int number3Limit = int.Parse(Console.ReadLine());
            for (int a = 1; a <= number1Limit; a++)
            {
                if (a % 2 != 0)
                {
                    continue;
                }

                for (int b = 1; b <= number2Limit; b++)
                {
                    if (b == 1 || b == 4 || b == 6 || b == 8 || b == 9)
                    {
                        continue;
                    }

                    for (int c = 1; c <= number3Limit; c++)
                    {
                        if (c % 2 != 0)
                        {
                            continue;
                        }

                        Console.WriteLine($"{a} {b} {c}");
                    }
                }
            }
        }
    }
}

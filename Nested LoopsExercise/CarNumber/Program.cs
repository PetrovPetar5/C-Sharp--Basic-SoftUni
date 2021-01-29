namespace CarNumber
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            bool isEven = false;
            bool isOdd = false;
            for (int a = start; a <= end; a++)
            {
                if (a % 2 == 0)
                {
                    isEven = true;
                    isOdd = false;
                }
                else
                {
                    isOdd = true;
                    isEven = false;
                }

                for (int b = start; b <= end; b++)
                {
                    for (int c = start; c <= end; c++)
                    {
                        if ((b + c) % 2 != 0)
                        {
                            continue;
                        }

                        for (int d = start; d <= end; d++)
                        {
                            if (isEven && d % 2 != 0 && a > d)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                            }
                            else if (isOdd && d % 2 == 0 && a > d)
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

namespace SpecialNumber
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int dig1 = 1; dig1 <= 9; dig1++)
            {
                if (number % dig1 != 0)
                {
                    continue;
                }

                for (int dig2 = 1; dig2 <= 9; dig2++)
                {
                    if (number % dig2 != 0)
                    {
                        continue;
                    }

                    for (int dig3 = 1; dig3 <= 9; dig3++)
                    {
                        if (number % dig3 != 0)
                        {
                            continue;
                        }

                        for (int dig4 = 1; dig4 <= 9; dig4++)
                        {
                            if (number % dig4 != 0)
                            {
                                continue;
                            }

                            Console.Write($"{dig1}{dig2}{dig3}{dig4} ");
                        }
                    }
                }
            }

        }
    }
}

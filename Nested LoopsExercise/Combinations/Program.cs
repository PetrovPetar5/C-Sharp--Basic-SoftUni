namespace Combinations
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int x1 = 0; x1 <= input; x1++)
            {
                for (int x2 = 0; x2 <= input; x2++)
                {
                    for (int x3 = 0; x3 <= input; x3++)
                    {
                        if (x1 + x2 + x3 == input)
                        {
                            counter++;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}

namespace LetterCombination
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char excluding = char.Parse(Console.ReadLine());
            int combinationC = 0;
            for (char a = start; a <= end; a++)
            {
                if (a == excluding)
                {
                    continue;
                }

                for (char b = start; b <= end; b++)
                {
                    if (b == excluding)
                    {
                        continue;
                    }

                    for (char c = start; c <= end; c++)
                    {
                        if (c == excluding)
                        {
                            continue;
                        }

                        Console.Write($"{a}{b}{c} ");
                        combinationC++;
                    }
                }
            }

            Console.Write($"{combinationC}");
        }
    }
}

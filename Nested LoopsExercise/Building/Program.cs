namespace Building
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            for (int fl = floors; fl >= 1; fl--)
            {
                for (int r = 0; r < rooms; r++)
                {
                    if (fl == floors)
                    {
                        Console.Write($"L{fl}{r} ");
                    }
                    else if (fl % 2 == 0)
                    {
                        Console.Write($"O{fl}{r} ");
                    }
                    else
                    {
                        Console.Write($"A{fl}{r} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}

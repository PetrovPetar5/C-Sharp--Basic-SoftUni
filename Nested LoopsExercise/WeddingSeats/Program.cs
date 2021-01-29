namespace WeddingSeats
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int rowsFirstSector = int.Parse(Console.ReadLine());
            int numOfSeatsOddRow = int.Parse(Console.ReadLine());
            int rows = rowsFirstSector;
            int seatCounter = 0;
            for (char a = 'A'; a <= lastSector; a++)
            {
                if (a != 'A')
                {
                    rows++;
                }
                for (int b = 1; b <= rows; b++)
                {
                    if (b % 2 != 0)
                    {
                        for (char c = 'a'; c < (char)numOfSeatsOddRow + 'a'; c++)
                        {
                            Console.WriteLine($"{a}{b}{c}");
                            seatCounter++;
                        }
                    }
                    else
                    {
                        for (char d = 'a'; d < (char)numOfSeatsOddRow + 2 + 'a'; d++)
                        {
                            Console.WriteLine($"{a}{b}{d}");
                            seatCounter++;
                        }
                    }
                }
            }

            Console.WriteLine($"{seatCounter}");
        }
    }
}

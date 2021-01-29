namespace FootballLeague
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fansNumber = int.Parse(Console.ReadLine());
            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;
            for (int counter = 0; counter < fansNumber; counter++)
            {
                string currentSector = Console.ReadLine();
                switch (currentSector)
                {
                    case "A":
                        sectorA++;
                        break;
                    case "B":
                        sectorB++;
                        break;
                    case "V":
                        sectorV++;
                        break;
                    case "G":
                        sectorG++;
                        break;
                }
            }

            Console.WriteLine($"{sectorA / (double)fansNumber * 100:F2}%");
            Console.WriteLine($"{sectorB / (double)fansNumber * 100:F2}%");
            Console.WriteLine($"{sectorV / (double)fansNumber * 100:F2}%");
            Console.WriteLine($"{sectorG / (double)fansNumber * 100:F2}%");
            Console.WriteLine($"{fansNumber / (double)capacity * 100:F2}%");
        }
    }
}

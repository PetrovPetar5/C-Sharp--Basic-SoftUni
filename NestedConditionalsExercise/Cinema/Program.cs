namespace Cinema
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int cinemaLimit = columns * rows;
            double price = 0;
            if (projection == "Premiere")
            {
                price = 12 * cinemaLimit;
            }
            else if (projection == "Normal")
            {
                price = 7.5 * cinemaLimit;
            }
            else
            {
                price = 5 * cinemaLimit;
            }

            Console.WriteLine($"{price:F2} leva");
        }
    }
}

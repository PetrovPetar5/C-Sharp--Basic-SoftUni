namespace SpeedInformation
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            double speedKm = double.Parse(Console.ReadLine());
            if (speedKm <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speedKm <=50)
            {
                Console.WriteLine("average");
            }
            else if (speedKm<=150)
            {
                Console.WriteLine("fast");
            }
            else if (speedKm <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}

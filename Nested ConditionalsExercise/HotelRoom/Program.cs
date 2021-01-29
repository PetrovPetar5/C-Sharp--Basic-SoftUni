namespace HotelRoom
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double apartmentPrice = 0;
            double studioPrice = 0;
            if (month == "May" || month == "October")
            {
                studioPrice = 50 * nights;
                apartmentPrice = 65 * nights;
                if (nights > 14)
                {
                    studioPrice *= 0.7;
                    apartmentPrice *= 0.9;
                }
                else if (nights > 7)
                {
                    studioPrice *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20 * nights;
                apartmentPrice = 68.7 * nights;
                if (nights > 14)
                {
                    studioPrice *= 0.8;
                    apartmentPrice *= 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                studioPrice = 76 * nights;
                apartmentPrice = 77 * nights;
                if (nights > 14)
                {
                    apartmentPrice *= 0.9;
                }
            }

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}


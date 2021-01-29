namespace SkiTrip
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int daysToStay = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();
            decimal roomPersonPrice = 18;
            decimal apartmentPrice = 25;
            decimal presidentApartment = 35;
            int nights = daysToStay - 1;
            decimal price = 0;
            decimal feedbackAmount = 0;
            if ((roomType == "apartment" || roomType == "room for one person" || roomType == "president apartment") && nights <= 9)
            {
                if (roomType == "apartment")
                {
                    price = nights * apartmentPrice * 0.70m;
                }
                else if (roomType == "room for one person")
                {
                    price = nights * roomPersonPrice;
                }
                else if (roomType == "president apartment")
                {
                    price = presidentApartment * nights * 0.90m;
                }
            }
            else if ((roomType == "apartment" || roomType == "room for one person" || roomType == "president apartment") && nights <= 15)
            {
                if (roomType == "apartment")
                {
                    price = nights * apartmentPrice * 0.65m;
                }
                else if (roomType == "room for one person")
                {
                    price = nights * roomPersonPrice;
                }
                else if (roomType == "president apartment")
                {
                    price = presidentApartment * nights * 0.85m;
                }
            }
            else if ((roomType == "apartment" || roomType == "room for one person" || roomType == "president apartment") && nights > 15)
            {
                if (roomType == "apartment")
                {
                    price = nights * apartmentPrice * 0.50m;
                }
                else if (roomType == "room for one person")
                {
                    price = nights * roomPersonPrice;
                }
                else if (roomType == "president apartment")
                {
                    price = presidentApartment * nights * 0.80m;
                }
            }

            if (feedback == "positive")
            {
                feedbackAmount = price * 0.25m;
                decimal finalPrice = feedbackAmount + price;
                Console.WriteLine($"{finalPrice:F2}");
            }
            else if (feedback == "negative")
            {
                feedbackAmount = price * 0.10m;
                decimal finalPrice = price - feedbackAmount;
                Console.WriteLine($"{finalPrice:F2}");
            }
        }
    }
}

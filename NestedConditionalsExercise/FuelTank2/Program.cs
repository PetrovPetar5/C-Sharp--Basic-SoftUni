namespace FuelTank2
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelLoaded = double.Parse(Console.ReadLine());
            string clubCardHolder = Console.ReadLine();
            bool isValid = true;
            if (clubCardHolder == "Yes")
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }

            double gasolinePerLitter = 2.22;
            double dieselPerLitter = 2.33;
            double gasPerLitter = 0.93;
            double fuelPrice = 0;
            if (fuelType == "Gasoline")
            {
                fuelPrice = fuelLoaded * gasolinePerLitter;
                if (isValid)
                {
                    fuelPrice = fuelPrice - fuelLoaded * 0.18;
                }
            }
            else if (fuelType == "Gas")
            {
                fuelPrice = fuelLoaded * gasPerLitter;
                if (isValid)
                {
                    fuelPrice = fuelPrice - fuelLoaded * 0.08;
                }
            }
            else if (fuelType == "Diesel")
            {
                fuelPrice = fuelLoaded * dieselPerLitter;
                if (isValid)
                {
                    fuelPrice = fuelPrice - fuelLoaded * 0.12;
                }
            }

            if (fuelLoaded >= 20 && fuelLoaded <= 25)
            {
                fuelPrice *= 0.92;
            }
            else if (fuelLoaded > 25)
            {
                fuelPrice *= 0.9;
            }

            Console.WriteLine($"{fuelPrice:F2} lv.");
        }
    }
}

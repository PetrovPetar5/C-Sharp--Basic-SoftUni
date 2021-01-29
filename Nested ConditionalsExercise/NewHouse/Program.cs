namespace NewHouse
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int flowerQuantity = int.Parse(Console.ReadLine());
            int familyBudget = int.Parse(Console.ReadLine());
            decimal rosePerCount = 5;
            decimal dahilaPerCount = 3.80m;
            decimal tuliPerCount = 2.8m;
            decimal narcissusPerCount = 3;
            decimal gladiolusPerCount = 2.5m;
            decimal flowersPrice = 0;
            if (flower == "Roses")
            {
                flowersPrice = flowerQuantity * rosePerCount;
                if (flowerQuantity > 80)
                {
                    flowersPrice *= 0.9m;
                }
            }
            else if (flower == "Dahlias")
            {
                flowersPrice = flowerQuantity * dahilaPerCount;
                if (flowerQuantity > 90)
                {
                    flowersPrice *= 0.85m;
                }
            }
            else if (flower == "Tulips")
            {
                flowersPrice = flowerQuantity * tuliPerCount;
                if (flowerQuantity > 80)
                {
                    flowersPrice *= 0.85m;
                }
            }
            else if (flower == "Narcissus")
            {
                flowersPrice = flowerQuantity * narcissusPerCount;
                if (flowerQuantity < 120)
                {
                    flowersPrice *= 1.15m;
                }
            }
            else if (flower == "Gladiolus")
            {
                flowersPrice = flowerQuantity * gladiolusPerCount;

                if (flowerQuantity < 80)
                {
                    flowersPrice *= 1.20m;
                }
            }

            decimal difference = Math.Abs(flowersPrice - familyBudget);
            if (familyBudget >= flowersPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerQuantity} {flower} and {difference:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {difference:F2} leva more.");
            }
        }
    }
}

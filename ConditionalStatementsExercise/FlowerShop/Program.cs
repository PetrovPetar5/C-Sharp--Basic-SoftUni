namespace FlowerShop
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int magnoliaCount = int.Parse(Console.ReadLine());
            int hyacinthCount = int.Parse(Console.ReadLine());
            int roseCount = int.Parse(Console.ReadLine());
            int cactusCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            double magnoliaPrice = 3.25;
            double hyacinthPrice = 4;
            double rosePrice = 3.5;
            double cactusPrice = 8;
            double orderCost = magnoliaCount * magnoliaPrice + hyacinthCount * hyacinthPrice + roseCount * rosePrice + cactusCount * cactusPrice;
            double orderProfit = orderCost * 0.95;
            double difference = Math.Abs(giftPrice - orderProfit);
            if (giftPrice <= orderProfit)
            {
                Console.WriteLine($"She is left with {Math.Floor(difference)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(difference)} leva.");
            }
        }
    }
}

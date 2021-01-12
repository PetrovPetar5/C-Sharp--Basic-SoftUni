namespace ToyShop
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int talkingDollCount = int.Parse(Console.ReadLine());
            int teddyBearCount = int.Parse(Console.ReadLine());
            int minionCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());
            double puzzlePerUnit = 2.60;
            double talkingDollPerUnit = 3;
            double teddyBearPerUnit = 4.10;
            double minionPerUnit = 8.20;
            double truckPerUnit = 2;
            int toyNumber = puzzleCount + talkingDollCount + teddyBearCount + minionCount + truckCount;
            double puzzleTotal = puzzleCount * puzzlePerUnit;
            double talkingDollTotal = talkingDollCount * talkingDollPerUnit;
            double teddyBearTotal = teddyBearCount * teddyBearPerUnit;
            double minionsTotal = minionCount * minionPerUnit;
            double truckToyTotal = truckCount * truckPerUnit;
            double totalToyPrice = puzzleTotal + talkingDollTotal + teddyBearTotal + minionsTotal + truckToyTotal;
            if (toyNumber >= 50)
            {
                totalToyPrice = totalToyPrice * 0.75;
            }
            double shopRent = totalToyPrice * 0.10;
            double moneyLeft = totalToyPrice - shopRent;
            double moneyLeftABS = Math.Abs(moneyLeft - vacationPrice);
            if (vacationPrice <= moneyLeft)
            {
                Console.WriteLine($"Yes! {moneyLeftABS:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {moneyLeftABS:F2} lv needed.");
            }
        }
    }
}

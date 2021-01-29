namespace CleverLily
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            decimal washingMachinePrice = decimal.Parse(Console.ReadLine());
            decimal toyPrice = decimal.Parse(Console.ReadLine());
            decimal birthdayMoney = 0;
            decimal toyCount = 0;
            decimal previousMoneyGift = 0;
            for (int counter = 0; counter < age; counter++)
            {
                int actualAge = counter + 1;
                if (actualAge % 2 == 0)
                {
                    birthdayMoney += 10 + previousMoneyGift - 1;
                    previousMoneyGift += 10;
                }
                else
                {
                    toyCount += 1;
                }
            }

            decimal totalSavedMoney = toyCount * toyPrice + birthdayMoney;
            decimal difference = Math.Abs(totalSavedMoney - washingMachinePrice);
            if (totalSavedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {difference:F2}");
            }
            else
            {
                Console.WriteLine($"No! {difference:F2}");
            }
        }
    }
}

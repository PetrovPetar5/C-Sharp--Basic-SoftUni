namespace Bills
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMonths = int.Parse(Console.ReadLine());
            int waterMonthlyBill = 20;
            int internetMonthlyBill = 15;
            double totalOtherExpense = 0;
            double totalElectricity = 0;
            for (int counter = 0; counter < numberOfMonths; counter++)
            {
                double electricityCurrentMonth = double.Parse(Console.ReadLine());
                totalElectricity += electricityCurrentMonth;
                totalOtherExpense += (electricityCurrentMonth + internetMonthlyBill + waterMonthlyBill) * 1.20;
            }

            int totalWaterBill = numberOfMonths * waterMonthlyBill;
            int totalInternetBill = internetMonthlyBill * numberOfMonths;
            double totalExpenses = (totalElectricity + totalWaterBill + totalInternetBill + totalOtherExpense) / numberOfMonths;
            Console.WriteLine($"Electricity: {totalElectricity:F2} lv");
            Console.WriteLine($"Water: {totalWaterBill:F2} lv");
            Console.WriteLine($"Internet: {totalInternetBill:F2} lv");
            Console.WriteLine($"Other: {totalOtherExpense:F2} lv");
            Console.WriteLine($"Average: {totalExpenses:F2} lv");
        }
    }
}

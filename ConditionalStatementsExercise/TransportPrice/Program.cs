namespace TransportPrice
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            decimal transportPrice = 0;
            if (distance < 20)
            {
                if (timeOfDay == "night")
                {
                    transportPrice = distance * 0.90m + 0.70m;
                }
                else
                {
                    transportPrice = distance * 0.79m + 0.70m;
                }

            }
            else if (distance < 100)
            {
                if (distance >= 20)
                {
                    transportPrice = distance * 0.09m;
                }
            }
            else
            {
                transportPrice = distance * 0.06m;
            }

            Console.WriteLine("{0:F2}", transportPrice);
        }
    }
}

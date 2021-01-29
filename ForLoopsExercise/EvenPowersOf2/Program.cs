namespace EvenPowersOf2
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int counter = 2; counter <= number; counter+=2)
            {
                Console.WriteLine(counter);
            }
        }
    }
}

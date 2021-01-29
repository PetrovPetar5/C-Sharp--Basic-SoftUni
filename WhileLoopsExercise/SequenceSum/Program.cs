namespace SequenceSum
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int numberToPrint = 1;
            while (numberToPrint <= numberInput)
            {
                Console.WriteLine($"{numberToPrint}");
                numberToPrint = numberToPrint * 2 + 1;
            }
        }
    }
}

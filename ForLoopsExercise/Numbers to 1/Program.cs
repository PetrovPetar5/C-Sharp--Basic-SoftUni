namespace NumbersTo1
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int counter = number; counter > 1; counter--)
            {
                Console.WriteLine(counter);
            }
        }
    }
}

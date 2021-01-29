namespace ReadInput
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;
            while (input != "Stop")
            {
                input = Console.ReadLine();
                Console.WriteLine(input);
            }
        }
    }
}

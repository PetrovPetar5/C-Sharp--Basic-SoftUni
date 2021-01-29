namespace CharacterSequence
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int counter = 0; counter < input.Length; counter++)
            {
                Console.WriteLine(input[counter]);
            }
        }
    }
}

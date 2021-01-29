namespace TheGreatestNumber
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int greatestNum = int.MinValue;
            for (int counter = 0; counter < inputNumber; counter++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > greatestNum)
                {
                    greatestNum = currentNumber;
                }
            }

            Console.WriteLine("{0}", greatestNum);
        }
    }
}

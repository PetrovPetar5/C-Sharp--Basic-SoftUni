namespace OperationsBetweenNumbers
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumberAsInput = int.Parse(Console.ReadLine());
            int secondNumberAsInput = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double result = 0;
            string evenOdd = String.Empty;
            if (operation == '+')
            {
                result = firstNumberAsInput + secondNumberAsInput;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }

                Console.WriteLine($"{firstNumberAsInput} {operation} {secondNumberAsInput} = {result} - {evenOdd}");
            }
            else if (operation == '-')
            {
                result = firstNumberAsInput - secondNumberAsInput;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }

                Console.WriteLine($"{firstNumberAsInput} {operation} {secondNumberAsInput} = {result} - {evenOdd}");
            }
            else if (operation == '*')
            {
                result = firstNumberAsInput * secondNumberAsInput;
                if (result % 2 == 0)
                {
                    evenOdd = "even";
                }
                else
                {
                    evenOdd = "odd";
                }

                Console.WriteLine($"{firstNumberAsInput} {operation} {secondNumberAsInput} = {result} - {evenOdd}");
            }
            else if (operation == '/' && secondNumberAsInput != 0)
            {
                double figure = 1.0 * firstNumberAsInput / secondNumberAsInput;
                Console.WriteLine($"{ firstNumberAsInput} / {secondNumberAsInput} = {figure:F2}");
            }
            else if (operation == '%' && secondNumberAsInput != 0)
            {
                result = firstNumberAsInput % secondNumberAsInput;
                Console.WriteLine($"{firstNumberAsInput} % {secondNumberAsInput} = {result}");
            }
            else
            {
                Console.WriteLine($"Cannot divide {firstNumberAsInput} by zero");
            }
        }
    }
}



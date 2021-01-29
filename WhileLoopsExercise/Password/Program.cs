namespace Password
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();
            string passwordInput = Console.ReadLine();
            while (passwordInput != password)
            {
                passwordInput = Console.ReadLine();
                if (passwordInput == password)
                {
                    break;
                }
            }

            Console.WriteLine($"Welcome {name}!");
        }
    }
}

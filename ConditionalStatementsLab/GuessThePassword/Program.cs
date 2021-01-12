namespace GuessThePassword
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            switch (password)
            {
                case "s3cr3t!P@ssw0rd":
                    Console.WriteLine("Welcome");
                    break;
                default:
                    Console.WriteLine("Wrong password!");
                    break;
            }
        }
    }
}

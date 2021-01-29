namespace AnimalClass
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string AnimalKind = Console.ReadLine();
            switch (AnimalKind)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}

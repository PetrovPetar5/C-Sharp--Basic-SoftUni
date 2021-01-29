namespace SmallShop
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double qunatity = double.Parse(Console.ReadLine());
            switch (product)
            {
                case "coffee":
                    switch (town)
                    {
                        case "Sofia":
                            Console.WriteLine(qunatity * 0.5);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(qunatity * 0.4);
                            break;
                        case "Varna":
                            Console.WriteLine(qunatity * 0.45);
                            break;
                    }
                    break;
                case "water":
                    switch (town)
                    {
                        case "Sofia":
                            Console.WriteLine(qunatity * 0.80);
                            break;
                        case "Plovdiv":
                        case "Varna":
                            Console.WriteLine(qunatity * 0.70);
                            break;
                    }
                    break;
                case "beer":
                    {
                        switch (town)
                        {
                            case "Sofia":
                                Console.WriteLine(qunatity * 1.20);
                                break;
                            case "Plovdiv":
                                Console.WriteLine(qunatity * 1.15);
                                break;
                            case "Varna":
                                Console.WriteLine(qunatity * 1.10);
                                break;
                        }
                        break;
                    }
                case "sweets":
                    switch (town)
                    {
                        case "Sofia":
                            Console.WriteLine(qunatity * 1.45);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(qunatity * 1.30);
                            break;
                        case "Varna":
                            Console.WriteLine(qunatity * 1.35);
                            break;
                    }
                    break;
                case "peanuts":
                    {
                        switch (town)
                        {
                            default:
                                break;
                            case "Sofia":
                                Console.WriteLine(qunatity * 1.60);
                                break;
                            case "Plovdiv":
                                Console.WriteLine(qunatity * 1.50);
                                break;
                            case "Varna":
                                Console.WriteLine(qunatity * 1.55);
                                break;
                        }
                    }
                    break;
            }
        }
    }
}


namespace WeddingChallenge
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            int tablesCounter = 0;
            for (int man = 1; man <= men; man++)
            {
                for (int woman = 1; woman <= women; woman++)
                {
                    Console.Write($"({man} <-> {woman}) ");
                    tablesCounter++;
                    if (tablesCounter == tables)
                    {
                        break;
                    }
                }

                if (tablesCounter == tables)
                {
                    break;
                }
            }
        }
    }
}

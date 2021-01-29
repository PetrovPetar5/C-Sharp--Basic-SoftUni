namespace TheOldLibrary
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string favBookName = Console.ReadLine();
            int libraryBooksNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool foundIt = false;
            while (counter < libraryBooksNum)
            {
                string currentBook = Console.ReadLine();
                if (currentBook == favBookName)
                {
                    foundIt = true;
                    break;
                }

                counter++;
            }

            if (foundIt)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {libraryBooksNum} books.");
            }
        }
    }
}

namespace VowelSum
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int sum = 0;
            for (int counter = 0; counter < text.Length; counter++)
            {
                char currentLetter = text[counter];
                switch (currentLetter)
                {
                    case 'a':
                        sum += 1;
                        break;
                    case 'o':
                        sum += 4;
                        break;
                    case 'i':
                        sum += 3;
                        break;
                    case 'u':
                        sum += 5;
                        break;
                    case 'e':
                        sum += 2;
                        break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

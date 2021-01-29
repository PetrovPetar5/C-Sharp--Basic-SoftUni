namespace Moving
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int widthApartment = int.Parse(Console.ReadLine());
            int lengthApartment = int.Parse(Console.ReadLine());
            int heightApartment = int.Parse(Console.ReadLine());
            int volumeApartment = widthApartment * lengthApartment * heightApartment;
            int totalBoxes = 0;
            string boxes = Console.ReadLine();
            while (boxes != "Done")
            {
                int currentBoxes = int.Parse(boxes);
                totalBoxes += currentBoxes;
                if (totalBoxes > volumeApartment)
                {
                    break;
                }

                boxes = Console.ReadLine();
            }

            int difference = Math.Abs(totalBoxes - volumeApartment);
            if (volumeApartment >= totalBoxes)
            {
                Console.WriteLine($"{difference} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {difference} Cubic meters more.");
            }
        }
    }
}

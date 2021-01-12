namespace FigureArea
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;
            if (figure == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                area = sideA * sideA;
            }
            else if (figure == "rectangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                area = width * lenght;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else
            {
                double triangleA = double.Parse(Console.ReadLine());
                double triangleHA = double.Parse(Console.ReadLine());
                area = triangleA * triangleHA / 2;
            }

            Console.WriteLine("{0:F3}",area);
            }
        }
    }


﻿namespace Clock
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            for (int days = 1; days <= 365; days++)
            {
                for (int hours = 0; hours <= 23; hours++)
                {
                    for (int minutes = 0; minutes <= 59; minutes++)
                    {
                        for (int seconds = 0; seconds <= 59; seconds++)
                        {
                            Console.WriteLine($"{days} day of the year. {hours}:{minutes}:{seconds}");
                        }
                    }
                }
            }
        }
    }
}

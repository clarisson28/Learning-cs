﻿using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ed's Big Give Away!");
            Console.Write("Choose a door: 1, 2, 3: ");
            string userValue = Console.ReadLine();

            if (userValue == "1")
            {
                string message = "You won a new car!";
                Console.WriteLine(message);
            }

            else if (userValue == "2")
            {
                string message = "You won a new boat!";
                Console.WriteLine(message);
            }

            else if (userValue == "3")
            {
                string message = "You won a new cat!";
                Console.WriteLine(message);
            }

            else
            {
                string message = "Sorry, we didn't understand.";
                Console.WriteLine(message);
            }

            Console.ReadLine();

        }
    }
}

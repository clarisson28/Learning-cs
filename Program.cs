using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ed's Big Give Away!");
            Console.Write("Choose a door: 1, 2, 3: ");
            string userValue = Console.ReadLine();

            string message = "";
            if (userValue == "1")
            {
                message = "You won a new car!";
            }

            else if (userValue == "2")
            {
                message = "You won a new boat!";
            }

            else if (userValue == "3")
            {
                message = "You won a new cat!";
            }

            else
            {
                message = "Sorry, we didn't understand.";
            }

            Console.WriteLine(message);
            Console.ReadLine();

        }
    }
}

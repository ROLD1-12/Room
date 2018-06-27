using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Room
{
    class Room
    {
        public static void Main()
        {
            // These are the different variables within the code. These are called below within the bulk of the code.
            double length, width, height, area, volume, paint;

            // The progam will check if the information provided is true.
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    // Length of room
                    Console.Write("Enter length of room in metres: ");
                    length = Convert.ToDouble(Console.ReadLine());
                    length = Math.Round(length, 2);

                    // Width of room
                    Console.Write("Enter width of room in metres: ");
                    width = Convert.ToDouble(Console.ReadLine());
                    width = Math.Round(width, 2);

                    // Height of room
                    Console.Write("Enter height of room in metres: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    height = Math.Round(height, 2);

                    // Area of room
                    area = length * width;
                    area = Math.Round(area, 2);
                    Console.Write("The room is " + area + " square metres,");

                    // Paint required
                    paint = length + width / 350;
                    paint = Math.Round(paint, 2);
                    Console.Write(" requires " + paint + " litres of paint and");

                    // Volume of room
                    volume = (length * width) * height;
                    volume = Math.Round(volume, 2);
                    Console.Write(" has a volume of " + volume + ".");
                    Console.ReadLine();
                }
                    //If you try and enter something that isn't a number the program will catch and request you re-enter the information.
                catch (Exception)
                {
                    Console.WriteLine("An error occurred. Please enter a number.");
                }
            }
        }
    }
}

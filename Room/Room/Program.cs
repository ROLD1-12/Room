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
            double length, width, height, area, volume, paint;

            // Catches an exception in the code and requests that you re-enter information.
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
                    Console.Write("Enter height of room: ");
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
                    //If you try and enter anything but a whole number the system will call an error and request you enter the details again.
                catch (Exception)
                {
                    Console.WriteLine("An error occurred. Please enter whole number.");
                }
            }
        }
    }
}

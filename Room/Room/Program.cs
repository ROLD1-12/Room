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
            int length, width, area, height, volume, paint;

            // Catches an exception in the code and requests that you re-enter information.
            bool tryAgain = true;
            while (tryAgain)
            {
                try
                {
                    // Length of room
                    Console.Write("Enter length of room in metres: ");
                    length = Convert.ToInt32(Console.ReadLine());

                    // Width of room
                    Console.Write("Enter width of room in metres: ");
                    width = Convert.ToInt32(Console.ReadLine());

                    // Height of room
                    Console.Write("Enter height of room: ");
                    height = Convert.ToInt32(Console.ReadLine());

                    // Area of room
                    area = length * width;
                    Console.Write("The room is " + area + " square metres,");

                    // Paint required
                    paint = length + width / 350;
                    Console.Write(" requires " + paint + " litres of paint and");

                    // Volume of room
                    volume = (length * width) * height;
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

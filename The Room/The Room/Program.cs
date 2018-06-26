
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The_Room
{
    class Room
    {
        public static void Main()
        {
            int length, width, area, height, volume, paint;

            // Length of room
            Console.Write("Enter length of room in metres: ");
            length = Convert.ToInt32 (Console.ReadLine());

            // Width of room
            Console.Write("Enter the width of room in metres: ");
            width = Convert.ToInt32(Console.ReadLine());

            // Height of room
            Console.Write("Now enter height of room: ");
            height = Convert.ToInt32(Console.ReadLine());

            // Area of room
            area = length * width;
            Console.Write("The room is " + area + " square metres,");

            // Paint required
            paint = length + width / 350;
            Console.Write(" requires " + paint + " litres of paint and");

            // Volume of room
            volume = length * width * height;
            Console.Write(" has a volume of " + volume + ".");
            Console.ReadLine();
        }
    }
}

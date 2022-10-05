using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, width;
            bool end = false;
            int input = 0;

            Console.Write("\n\n");
            Console.Write("Rectangle Finder \n");
            Console.Write("================================================ \n");
            {
                // Asking for length of the Rectangle
                Console.Write("Please enter the Length of the Rectangle: \n");
                do
                {
                    if ((!int.TryParse(Console.ReadLine(), out length)) || (length <= 0))
                    {
                        Console.Write("Please enter a valid value for length \n");
                    }
                    else { end = true; }
                } while (!end);
                end = false;

                // Asking for width of the Rectangle
                Console.Write("Please enter the Width of the Rectangle: \n");
                do
                {
                    if ((!int.TryParse(Console.ReadLine(), out width)) || (width <= 0))
                    {
                        Console.Write("Please enter a valid value for width \n");
                    }
                    else { end = true; }
                } while (!end);
                end = false;
            }

            RectangleTesting rect = new RectangleTesting();
            rect.Length = length;
            rect.Width = width;

            while (!end)
            {
                Console.WriteLine("\n Please enter \n 1 to get Area of Rectangle \n 2 to het Perimeter of Rectangle \n 3 to get the Current Length of Rectangle\n 4 to get the Current Width of the Rectangle \n 5 to set New Length of Rectangle \n 6 to set New Width of Rectangle \n 7 to close the program");
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.Write("Please enter a valid value for width \n");
                }

                switch (input)
                {
                    case 1:
                        int rectArea = rect.GetArea();
                        Console.Write("\n Area of the Rectangle = " + rectArea);
                        break;
                    case 2:
                        int rectPerimeter = rect.GetPerimeter();
                        Console.Write("\n Perimeter of the Rectangle = " + rectPerimeter);
                        break;
                    case 3:
                        int currentLength = rect.GetCurrentLength();
                        Console.Write("\n Current Length of the Rectangle = " + currentLength);
                        break;
                    case 4:
                        int currentWidth = rect.GetCurrentWidth();
                        Console.Write("\n Current Width of the Rectangle = " + currentWidth);
                        break;
                    case 5:
                        Console.Write("\n Please enter the new Length of the Rectangle:");
                        do
                        {
                            if ((!int.TryParse(Console.ReadLine(), out length)) || (length <= 0))
                            {
                                Console.Write("Please enter a valid value for length \n");
                            }
                            else { end = true; }
                        } while (!end);
                        end = false;
                        rect.SetNewLength(length);
                        break;
                    case 6:
                        Console.Write("\n Please enter the new Width of the Rectangle:");
                        do
                        {
                            if ((!int.TryParse(Console.ReadLine(), out width)) || (width <= 0))
                            {
                                Console.Write("Please enter a valid value for width \n");
                            }
                            else { end = true; }
                        } while (!end);
                        end = false;
                        rect.SetNewWidth(width);
                        break;
                    default:
                        end = true;
                        break;
                }
            }
        }
    }
}

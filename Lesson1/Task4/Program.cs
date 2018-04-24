using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static int ax, ay, bx, by, cx, cy, lenghtSide;

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Calculate lenght and perimetr polygon v 1.0");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Enter X coordinate point 'A':");
            ax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y coordinate point 'A':");
            ay = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter X coordinate point 'B':");
            bx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y coordinate point 'B':");
            by = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter X coordinate point 'C':");
            cx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y coordinate point 'C':");
            cy = Convert.ToInt32(Console.ReadLine());

            Point PointA = new Point(ax, ay);
            Point PointB = new Point(bx, by);
            Point PointC = new Point(cx, cy);
            Point PointD = new Point(1, 0);

            Figure Polygon = new Figure(PointA, PointB, PointC, PointD);

            lenghtSide = Convert.ToInt32(Polygon.LengthSide(PointA, PointB));

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Lenght side: " + lenghtSide);
            Console.WriteLine("Perimetr polygon: " + Polygon.PerimetrCalculator());

            Console.ReadKey();
            return;
        }
    }
}

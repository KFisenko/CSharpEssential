using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            string side1 , side2;

            Console.WriteLine("Enter side rectangle");
            Console.WriteLine("Side 1:");
            side1 = Console.ReadLine();
            Console.WriteLine("Side 2:");
            side2 = Console.ReadLine();
            Rectangle CurrentRectangle = new Rectangle(Convert.ToDouble(side1), Convert.ToDouble(side2));
            Console.WriteLine("Results calculate: ");
            Console.WriteLine("Area: " + CurrentRectangle.Area);
            Console.WriteLine("Perimetr: " + CurrentRectangle.Perimetr);
            Console.ReadKey();

        }
    }
}

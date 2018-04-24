using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Rectangle
    {
        //--- Создание приватных полей класса
        private double side1, side2;

        //--- Создание пользовательского конструктора с параметрами для инициализации переменных
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        //--- Метод для вычисления площади прямоугольника
        public double AreaCalculator()
        {
            return (side1 * side2);
        }

        //--- Метод для вычисления периметра прямоугольника
        public double PerimetrCalculator()
        {
            return ((2 * side1) + (2 * side2));
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }

        public double Perimetr
        {
            get
            {
                return PerimetrCalculator();
            }
        }
    }
}

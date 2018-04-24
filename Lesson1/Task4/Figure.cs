using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Figure
    {
        Point pointA, pointB, pointC, pointD, pointE;
        public Figure(Point a, Point b, Point c)
        {
            pointA = a;
            pointB = b;
            pointC = c;
        }

        public Figure(Point a, Point b, Point c, Point d) : this(a, b, c)
        {
            pointD = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e) : this(a, b, c, d)
        {
            pointE = e;
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.POx - A.POx, 2) + Math.Pow(B.POy - A.POy, 2));
        }

        public double PerimetrCalculator()
        {
            if (pointD == null)
            {
                return LengthSide(pointA, pointB) + LengthSide(pointB, pointC) + LengthSide(pointC, pointA);
            }

            if (pointE == null)
            {
                /*var p1 = LengthSide(pointA, pointB);
                var p2 = LengthSide(pointB, pointC);
                var p3 = LengthSide(pointC, pointD);
                var p4 = LengthSide(pointD, pointA);*/
                return LengthSide(pointA, pointB) + LengthSide(pointB, pointC) + 
                    LengthSide(pointC, pointD) + LengthSide(pointD, pointA);
            }

            return LengthSide(pointA, pointB) + LengthSide(pointB, pointC) +
                    LengthSide(pointC, pointD) + LengthSide(pointD, pointE) + LengthSide(pointE, pointA);
        }
    }
}

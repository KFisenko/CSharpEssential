using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Point
    {
        int pOx, pOy;
        string str;

        //--- Создание собственного конструктора класса
        public Point(int pOx, int pOy)
        {
            this.pOx = pOx;
            this.pOy = pOy;
        }

        public int POx
        {
            get
            {
                return pOx;
            }
        }

        public int POy
        {
            get
            {
                return pOy;
            }
        }

        public string Str
        {
            get
            {
                return Str;
            }
        }
    }
}

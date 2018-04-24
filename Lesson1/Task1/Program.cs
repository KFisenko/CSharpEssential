using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //--- Создание экземпляра класса по "сильной" ссылке
            Addres PostAddr = new Addres();

            PostAddr.Apartment = "45";
            PostAddr.House = "28";
            PostAddr.Street = "Himikov";
            PostAddr.City = "Omsk";
            PostAddr.Countru = "Russia";            
            PostAddr.Index = "644011";

            Console.WriteLine(PostAddr.Apartment);
            Console.WriteLine(PostAddr.House);
            Console.WriteLine(PostAddr.Street);
            Console.WriteLine(PostAddr.City);
            Console.WriteLine(PostAddr.Countru);
            Console.WriteLine(PostAddr.Index);
            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Book: ");
            Book CurrentBook = new Book();
            CurrentBook.ShowBook();
            Console.WriteLine("Press 'y' for edit or any another button for exit");

            if (Console.Read() != 'y')
            {
                return;
            }

            Console.WriteLine("Enter title:");
            CurrentBook.EditTitle(Console.ReadLine());
            CurrentBook.EditTitle(Console.ReadLine());

            Console.WriteLine("Enter author: ");
            CurrentBook.EditAuthor(Console.ReadLine());

            Console.WriteLine("Enter content: ");
            CurrentBook.EditContent(Console.ReadLine());

            Console.WriteLine("Current Book: ");
            CurrentBook.ShowBook();
            Console.WriteLine("Press any key for exit");
            Console.ReadKey();
        }
    }
}

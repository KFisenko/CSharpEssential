using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Author
    {
        private string currentAuthor;

        public Author()
        {
            this.currentAuthor = "Author";
        }

        public string CurrentAuthor
        {
            set
            {
                currentAuthor = value;
            }

            get
            {
                if (currentAuthor != null)
                    return currentAuthor;
                else
                    return "Отсутствует заголовок!";
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(currentAuthor);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

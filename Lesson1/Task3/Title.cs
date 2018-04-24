using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Title
    {
        private string currentTitle;

        public Title()
        {
            this.currentTitle = "Title";            
        }

        public string CurrentTitle
        {
            set
            {                
                currentTitle = value;
            }

            get
            {
                if (currentTitle != null)
                    return currentTitle;
                else
                    return "Отсутствует заголовок!";
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(CurrentTitle);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

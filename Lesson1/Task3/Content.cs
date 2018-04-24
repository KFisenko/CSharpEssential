using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Content
    {
        private string currentContent;

        public Content()
        {
            this.currentContent = "Content";
        }

        public string CurrentContent
        {
            set
            {
                currentContent = value;
            }

            get
            {
                if (currentContent != null)
                    return currentContent;
                else
                    return "Отсутствует заголовок!";
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(currentContent);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

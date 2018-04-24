using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        Title TmpTitle = new Title();
        Author TmpAuthor = new Author();
        Content TmpContent = new Content();

        public void EditTitle(string title)
        {
            TmpTitle.CurrentTitle = title;
        }

        public void EditAuthor(string author)
        {
            TmpAuthor.CurrentAuthor = author;
        }

        public void EditContent(string content)
        {
            TmpContent.CurrentContent = content;
        }

        public void ShowBook()
        {            
            TmpTitle.Show();
            TmpAuthor.Show();
            TmpContent.Show();

        }
    }        
}

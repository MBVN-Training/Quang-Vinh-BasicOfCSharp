using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary
{
    public class Book : LibraryItem
    {
        public Book(int id, string title, string author, DateTime publicatonDate, int numberOfPage) : base(id, title, author, publicatonDate)
        {
            NumberOfPages = numberOfPage;
        }
        public Book(LibraryItem item, int numberOfPage): base(item.Id, item.Title, item.Author, item.PublicatonDate) 
        {
                NumberOfPages = numberOfPage;
        }

        public int NumberOfPages { get; set; }

        public override string ToString()
        {
            return base.ToString() + " \n Number of page:" + NumberOfPages + " \n Type: Book";
                    
        }
    }
}

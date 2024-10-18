using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary
{
    public class LibraryItem
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Author { set; get; }
        public DateTime PublicatonDate { set; get; }

        public bool isAvailable { set; get; } = true ;

        public LibraryItem (int id, string title, string author, DateTime publicatonDate)
        {
            Id = id;
            Title = title;
            Author = author;
            PublicatonDate = publicatonDate;
        }
        public LibraryItem()
        {

        }
        public override string ToString()
        {
            return $"ID:{Id}" +
                   $"\n Title: {Title}" +
                   $"\n Author: {Author} " +
                   $"\n PublicationDate: {PublicatonDate} " +
                   $"\n isAvailable: {isAvailable}";
        }
    }
}

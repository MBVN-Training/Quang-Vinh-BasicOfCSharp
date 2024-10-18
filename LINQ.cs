using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary
{
    public class LINQ
    {
        public static List<LibraryItem> GetAllBooks(List<LibraryItem> libraryItems)
        {
            var books = libraryItems.FindAll(item => item.GetType() == typeof(Book));
            if (books != null)
            {
                foreach (var book in books)
                {
                    Console.WriteLine(book);
                }
                return books;
            }
            return null;
        }
        public static List<LibraryItem> ArrangingBook(List<LibraryItem> libraryItems)
        {
            var books = LINQ.GetAllBooks(libraryItems);

            if (books != null)
            {
                var sortBooks = books.OrderBy(item => item.Title).ToList();
                foreach (var book in sortBooks)
                {
                    Console.WriteLine(book);
                }
                return sortBooks;
            }
            return null;

        }
        public static List<LibraryItem> GetDvdIn2022(List<LibraryItem> libraryItems)
        {
             var dvdIn2022 = libraryItems.FindAll(item => item.GetType() == typeof(DVD) && (item.PublicatonDate.Year) == 2022);
             if(dvdIn2022 != null)
             { 
                foreach(var dvd in dvdIn2022) 
                { 
                    Console.WriteLine(dvd);
                }
                return dvdIn2022;
             } 
             return null;
        }
        public static List<Borrower> GetUserAllHaveBookanDvD(List<LibraryItem> libraryItems, List<Borrower> borrowers, List<BorrowingHistory> borrowingHistories) 
        {
            var listBorrowers = borrowers.Where(b => borrowingHistories.Where(bh => bh.BorrowerLibraryCardNumber == b.LibraryCardNumber)
            .Join(libraryItems, bh => bh.IdItem, li => li.Id, (bh, li) => li)
            .Where(li => li is Book || li is DVD)
            .Distinct()
            .Count() == 2)
            .GroupBy(b => b.LibraryCardNumber)
            .Select(g => g.First())
            .ToList();
            if (listBorrowers != null)
            {
                foreach (var borrower in listBorrowers)
                {
                    Console.WriteLine(borrower);
                }
                return listBorrowers;
            }
            return null;
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary
{
    public class Database
    {
        public List<LibraryItem> LibraryItems { get; set; } = new List<LibraryItem>();
        public List<Borrower> Borrowers { get; set; } = new List<Borrower>();
        public List<BorrowingHistory> BorrowingHistories { get; set; } = new List<BorrowingHistory>();

        public void SeedData()
        {
            var book1 = new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", new DateTime(1925, 4, 10), 218);
            var book2 = new Book(2, "1984", "George Orwell", new DateTime(1949, 6, 8), 328);
            var book3 = new Book(3, "To Kill a Mockingbird", "Harper Lee", new DateTime(1960, 7, 11), 281);
            var book4 = new Book(4, "Moby Dick", "Herman Melville", new DateTime(1851, 10, 18), 635);
            var book5 = new Book(5, "Pride and Prejudice", "Jane Austen", new DateTime(1813, 1, 28), 432);
            var book6 = new Book(6, "The Catcher in the Rye", "J.D. Salinger", new DateTime(1951, 7, 16), 277);
            LibraryItems.AddRange(new[] { book1, book2, book3, book4, book5, book6 });


            var dvd1 = new DVD(7, "Inception", "Christopher Nolan", new DateTime(2010, 7, 16), 148);
            var dvd2 = new DVD(8, "The Matrix", "The Wachowskis", new DateTime(1999, 3, 31), 136);
            var dvd3 = new DVD(9, "The Shawshank Redemption", "Frank Darabont", new DateTime(1994, 9, 23), 142);
            var dvd4 = new DVD(10, "The Godfather", "Francis Ford Coppola", new DateTime(1972, 3, 24), 175);
            var dvd5 = new DVD(11, "Pulp Fiction", "Quentin Tarantino", new DateTime(1994, 10, 14), 154);
            var dvd6 = new DVD(12, "Fight Club", "David Fincher", new DateTime(1999, 10, 15), 139);

            LibraryItems.AddRange(new[] { dvd1, dvd2, dvd3, dvd4, dvd5, dvd6 });
        }
        public List<LibraryItem> GetItems()
        {
            return LibraryItems;
        }
        public List<Borrower> GetBorrowers()
        {
            return Borrowers;
        }
        public List<BorrowingHistory> GetBorrowingHistories()
        {
            return BorrowingHistories;
        }
    }
}

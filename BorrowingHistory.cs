using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary
{
    public class BorrowingHistory
    {
        public int BorrowerLibraryCardNumber { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int IdItem { get; set; }

        public BorrowingHistory (int borrowerLibraryCardNumber, DateTime borrowDate, int idItem)
        {
            BorrowerLibraryCardNumber = borrowerLibraryCardNumber;
            BorrowDate = borrowDate;
          
            IdItem = idItem;
        }
        public override string ToString()
        {
            return $"BorrowerLibraryCardNumber: {BorrowerLibraryCardNumber}" +
                   $"\n BorrowDate: {BorrowDate}" +
                   $"\n ReturnDate: {ReturnDate}" +
                   $"\n IdItem: {IdItem}";
        }
    }
}

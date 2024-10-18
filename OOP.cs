using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageLibrary
{
    public class OOP
    {
        static public void CreateNewItem(List<LibraryItem> listItems)
        {
            try
            {
                var item = new LibraryItem();
                Console.WriteLine("Enter the number of item that you want to create new");
                int numberOfItems = int.Parse(Console.ReadLine());
                for (int i = 1; i <= numberOfItems; i++)
                {
                    try
                    {
                        Console.WriteLine("Are you want to create Book or DVD");
                        Console.WriteLine("Press 1 to create Book or Press 2 to create DVD");
                        int index = int.Parse(Console.ReadLine());

                        if (index > 2 || index < 1)
                        {
                            Exception ex = new CustomException.OutOfOptionException();
                            throw ex;
                        }

                        Console.WriteLine("Enter the Id");
                        item.Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Title");
                        item.Title = Console.ReadLine();
                        Console.WriteLine("Entre the Author");
                        item.Author = Console.ReadLine();
                        Console.WriteLine("Enter the date that the item has been published");
                        item.PublicatonDate = DateTime.Parse(Console.ReadLine());

                        switch (index)
                        {
                            case 1:
                                Console.WriteLine("Enter the Number of Pages");
                                int numberOfPages = int.Parse(Console.ReadLine());
                                var book = new Book(item, numberOfPages);
                                listItems.Add(book);
                                break;
                            case 2:
                                Console.WriteLine("Enter the Run time");
                                int runTime = int.Parse(Console.ReadLine());
                                var dVD = new DVD(item, runTime);
                                listItems.Add(dVD);
                                break;
                            default:
                                Console.WriteLine("Invalid selection. Please choose add DVD or Book");
                                i--;
                                break;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                        i--;
                    }
                    catch (CustomException.OutOfOptionException ex)
                    {
                        Console.WriteLine(ex.Message);
                        i--;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static public List<LibraryItem> AdjustItem(List<LibraryItem> libraryItems)
        {
            try
            {
                Console.WriteLine("Enter id that you want to adjust");
                int id = int.Parse(Console.ReadLine());

                var item = libraryItems.Find(i => i.Id == id);
                if (item != null)
                {
                    Console.WriteLine("Enter the Title");
                    string title = Console.ReadLine();
                    Console.WriteLine("Entre the Author");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter the date");
                    DateTime publicationDate = DateTime.Parse(Console.ReadLine());

                    item.Title = title;
                    item.Author = author;
                    item.PublicatonDate = publicationDate;

                    if (item is Book book)
                    {
                        Console.WriteLine("Enter the Number of Pages");
                        int numberOfPages = int.Parse(Console.ReadLine());

                        book.NumberOfPages = numberOfPages;
                    }
                    if (item is DVD dvd)
                    {
                        Console.WriteLine("Enter the runtime");
                        int runTime = int.Parse(Console.ReadLine());

                        dvd.RunTime = runTime;
                    }
                    return libraryItems;

                }
                Console.WriteLine("Can not find item");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return libraryItems;

        }
        static public List<LibraryItem> DeleteItem(List<LibraryItem> libraryItems)
        {
            try
            {
                Console.WriteLine("Enter id that you want to delete");
                int id = int.Parse(Console.ReadLine());

                var item = libraryItems.Find(i => i.Id == id);

                if (item != null)
                {
                    libraryItems.Remove(item);
                    return libraryItems;
                }
                Console.WriteLine("Can not find the item");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, please input value can convert to integer");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return libraryItems;
        }
        static public bool IsExistItem(List<LibraryItem> libraryItems)
        {
            try
            {
                Console.WriteLine("Enter id item that you want to check it existed");
                int id = int.Parse(Console.ReadLine());
                var item = libraryItems.Any(i => i.Id == id);
                if (!item)
                {
                    return false;
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;

        }
        static public void ShowAllItems(List<LibraryItem> libraryItems)
        {
            foreach (var item in libraryItems)
            {
                if (item is Book book)
                {
                    Console.WriteLine(item);
                }
                if (item is DVD dVD)
                {
                    Console.WriteLine(item);
                }
            }
        }
        static public void BorrowItem(List<LibraryItem> libraryItems, List<Borrower> borrowers, List<BorrowingHistory> borrowingHistories)
        {
            try
            {
                Console.WriteLine("Enter id item which are borrowed");
                int id = int.Parse(Console.ReadLine());

                var item = libraryItems.Find(i => i.Id == id);

                if (item != null)
                {
                    item.isAvailable = false;

                    Console.WriteLine("Enter the personal name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the address");
                    string address = Console.ReadLine();
                    Console.WriteLine("Enter library card number");
                    int libraryCardNumber = int.Parse(Console.ReadLine());

                    Borrower borrower = new Borrower(name, address, libraryCardNumber);
                    borrowers.Add(borrower);

                    BorrowingHistory borrowingHistory = new BorrowingHistory(libraryCardNumber, DateTime.Now, item.Id);
                    borrowingHistories.Add(borrowingHistory);

                    Console.WriteLine(borrowingHistory);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static public void ReturnItem(List<LibraryItem> libraryItems, List<Borrower> borrowers,List<BorrowingHistory> borrowingHistories)
        {
            try
            {
                Console.WriteLine("Enter id item which are borrowed");
                int id = int.Parse(Console.ReadLine());

                var item = libraryItems.Find(i => i.Id == id);

                if (item != null)
                {
                    item.isAvailable = false;

                    Console.WriteLine("Enter the personal name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the address");
                    string address = Console.ReadLine();
                    Console.WriteLine("Enter library card number");
                    int libraryCardNumber = int.Parse(Console.ReadLine());

                    Borrower borrower = new Borrower(name, address, libraryCardNumber);
                    borrowers.Add(borrower);

                    BorrowingHistory borrowingHistory = new BorrowingHistory(libraryCardNumber, DateTime.Now, item.Id);
                    borrowingHistories.Add(borrowingHistory);

                    Console.WriteLine(borrowingHistory);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}


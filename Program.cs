using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ManageLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database data = new Database();
            data.SeedData();
            var libraryItems = data.GetItems();
            var borrower = data.GetBorrowers();
            var borrowingHistory = data.GetBorrowingHistories();

            while (true)
            {
                try
                {
                    Console.WriteLine($"Press 1 to open OOP Exercise" +
                                  $"\n Press 2 to open LINQ Exercise" +
                                  $"\n Press 3 to Exit");

                    int exercise1 = int.Parse(Console.ReadLine());

                    if (exercise1 > 3 || exercise1 < 1)
                    {
                        throw new CustomException.OutOfOptionException();
                    }
                    switch (exercise1)
                    {
                        case 1:
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Press 1 to create new item" +
                                                  " \n Press 2 to adjust item" +
                                                  " \n Press 3 to delete item" +
                                                  " \n Press 4 to check item that is existed" +
                                                  " \n Press 5 to show all items" +
                                                  " \n Press 6 to add borrower" +
                                                  " \n Press 7 to return item" +
                                                  " \n Press 8 to Exit");
                                        int index = int.Parse(Console.ReadLine());
                                        if(index < 1 || index > 8)
                                        {
                                            throw new CustomException.OutOfOptionException();
                                        }

                                        switch (index)
                                        {
                                            case 1:
                                                OOP.CreateNewItem(libraryItems);
                                                break;
                                            case 2:
                                                OOP.AdjustItem(libraryItems);
                                                break;
                                            case 3:
                                                OOP.DeleteItem(libraryItems);
                                                break;
                                            case 4:
                                                if (OOP.IsExistItem(libraryItems))
                                                {
                                                    Console.WriteLine("Item is existed");
                                                    break;
                                                }
                                                Console.WriteLine("Item isn't existed");
                                                break;
                                            case 5:
                                                OOP.ShowAllItems(libraryItems);
                                                break;
                                            case 6:
                                                OOP.BorrowItem(libraryItems, borrower, borrowingHistory);
                                                break;
                                            case 7:
                                                OOP.ReturnItem(libraryItems, borrower, borrowingHistory);
                                                break;
                                            case 8:
                                                Console.WriteLine("Exit");
                                                break;
                                        }
                                        if (index == 8)
                                            break;
                                    }
                                    catch (CustomException.OutOfOptionException ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        continue;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                }
                                break;
                            }
                        case 2:
                            {
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine($"Press 1 to get all books " +
                                                      $"\n Press 2 to arranging books " +
                                                      $"\n Press 3 to get DvD in 2022 " +
                                                      $"\n Press 4 to get User all have Book and Dvd " +
                                                      $"\n Press 5 to Exit");
                                        int exercise2 = int.Parse(Console.ReadLine());

                                        if( exercise2 < 1 || exercise2 > 5 )
                                        {
                                            throw new CustomException.OutOfOptionException();
                                        }

                                        switch (exercise2)
                                        {
                                            case 1:
                                                LINQ.GetAllBooks(libraryItems);
                                                break;
                                            case 2:
                                                LINQ.ArrangingBook(libraryItems);
                                                break;
                                            case 3:
                                                LINQ.GetDvdIn2022(libraryItems);
                                                break;
                                            case 4:
                                                LINQ.GetUserAllHaveBookanDvD(libraryItems, borrower, borrowingHistory);
                                                break;
                                            case 5:
                                                break;
                                        }
                                        if (exercise2 == 5)
                                            break;
                                    }
                                    catch (CustomException.OutOfOptionException ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                        continue;
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                }
                                break;

                            }
                        case 3:
                            break;
                            

                    }
                    break;
                }
                catch (CustomException.OutOfOptionException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            }
        }
    }



using LibraryManagementSystem;
using System.Numerics;
using static LibraryManagementSystem.UsingFunction;




BookService bookService = new BookService();

string  TransactionChoice;
do
{
    UsingFunction.DisplayBooksMenu();

    TransactionChoice = Console.ReadLine();
    if (int.TryParse(TransactionChoice, out int Choice))
    {
        Console.Clear();
        switch (int.Parse(TransactionChoice))
        {    
            case (int)(Enumm.DisplayAllAvailableBooks):

                Console.Clear();

                bookService.DisplayAllAvailableBooks();

                UsingFunction.GetDisplayAllAvailableBooksNextAction();

                if (UserAction.NextAction == "*")
                {
                    Console.Clear();
                    TransactionChoice = "8";
                    Console.WriteLine("\n**Transaction complete thank you for using our services**\n");
                }

                else if (UserAction.NextAction == "$")
                {
                    Console.Clear();
                    continue;
                }
                break;

            case (int)(Enumm.BorrowaBook):
                do
                {
                    Console.Clear();

                    bookService.BorrowBooks();

                    UsingFunction.GetBorrowNextAction();

                    if (UserAction.NextAction == "*")
                    {
                        Console.Clear();
                        TransactionChoice = "8";
                        Console.WriteLine("\n**Transaction complete thank you for using our services**\n");
                    }

                    else if (UserAction.NextAction == "$")
                    {
                        Console.Clear();
                        continue;
                    }
                } while (UserAction.NextAction == "#");
                break;

            case (int)(Enumm.ReturnaBook):
                do
                {
                    Console.Clear();

                    bookService.ReturnBooks();

                    UsingFunction.GetReturnNextAction();

                    if (UserAction.NextAction == "*")
                    {
                        Console.Clear();
                        TransactionChoice = "8";
                        Console.WriteLine("\n**Transaction complete thank you for using our services**\n");
                    }

                    else if (UserAction.NextAction == "$")
                    {
                        Console.Clear();
                        continue;
                    }

                } while (UserAction.NextAction == "#");
                break;

            case (int)(Enumm.CheckBookAvailability):
                do
                {
                    Console.Clear();

                    bookService.CheckBookAvailability();

                    UsingFunction.GetCheckAvailabilityNextAction();

                    if (UserAction.NextAction == "*")
                    {
                        Console.Clear();
                        TransactionChoice = "8";
                        Console.WriteLine("\n**Transaction complete thank you for using our services**\n");
                    }

                    else if (UserAction.NextAction == "$")
                    {
                        Console.Clear();
                        continue;
                    }

                } while (UserAction.NextAction == "#");
                break;

            case (int)(Enumm.AddABooks):
                do
                {
                    Console.Clear();

                    bookService.AddBooks();

                    UsingFunction.GetAddABooksNextAction();

                    if (UserAction.NextAction == "*")
                    {
                        Console.Clear();
                        TransactionChoice = "8";
                        Console.WriteLine("\n**Transaction complete thank you for using our services**\n");
                    }

                    else if (UserAction.NextAction == "$")
                    {
                        Console.Clear();
                        continue;
                    }

                } while (UserAction.NextAction == "#");
                break;

            case (int)(Enumm.DeleteABook):
                do
                {
                    Console.Clear();

                    bookService.DeleteBooks();

                    UsingFunction.GetDeleteABooksNextAction();

                    if (UserAction.NextAction == "*")
                    {
                        Console.Clear();
                        TransactionChoice = "8";
                        Console.WriteLine("\n**Transaction complete thank you for using our services**\n");
                    }

                    else if (UserAction.NextAction == "$")
                    {
                        Console.Clear();
                        continue;
                    }

                } while (UserAction.NextAction == "#");
                break;

            case (int)(Enumm.UpdateTheBook):
                do
                {
                    Console.Clear();

                    bookService.UpdateBooks();

                    UsingFunction.GetUpdateeABooksNextAction();

                    if (UserAction.NextAction == "*")
                    {
                        Console.Clear();
                        TransactionChoice = "8";
                        Console.WriteLine("\n**Transaction complete thank you for using our services**\n");
                    }

                    else if (UserAction.NextAction == "$")
                    {
                        Console.Clear();
                        continue;
                    }

                } while (UserAction.NextAction == "#");
                break;


            case (int)(Enumm.Exit):

                Console.Clear();

                Console.WriteLine("\n**Transaction completed thank you for using our library services.**\n");
                break;
            default:
                Console.WriteLine("\n**Please try again**\n");
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("\n**Please try again**\n");
    }
} while (TransactionChoice != "8");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static LibraryManagementSystem.UsingFunction;

namespace LibraryManagementSystem
{
    internal class BookService
    {
        public List<Book> Books = new List<Book>()
        {
        new Book("1", "CSharpBasics", "An introduction to C# programming covering variables, loops, and methods", 5),

        new Book("2", "DataStructuresInCSharp", "Learn about arrays, lists, stacks, queues, and trees using C", 3),

        new Book("3", "Object-Oriented Programming", "A guide to understanding classes, objects, inheritance, and polymorphism", 4),

        new Book("4", "Database Fundamentals", "Covers SQL, database design, and how to connect databases with C", 2),

        new Book("5", "Algorithms Made Easy", "Explains sorting, searching, and problem-solving algorithms step by step", 3),
        };

        public List<Book> BooksAvailabe = new List<Book>()
        {

        };

        public void DisplayAllAvailableBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine($"\nBook Title: {book.bookTitle}\nDescription: {book.description}\nRemaining Quantity: {book.remainingQuantity}");
            }
        }

        public void BorrowBooks()
        {
            do
            {
                int FirstId = 0;
                NumbOfBooK.numOfBook = 0;
                Console.WriteLine("Select the book you want to borrow by entering its number:\n");

                foreach (Book book in Books)
                {
                    Console.WriteLine(book.Id + ": " + book.bookTitle);

                    while (LoopControl.ContinueLoop == 1)
                    {
                        FirstId = int.Parse(book.Id);
                        LoopControl.ContinueLoop = 0;
                    }
                    NumbOfBooK.numOfBook++;
                }

                LoopControl.ContinueLoop = 1;
                selects.select = Console.ReadLine();
                Book BookAvailablee = BooksAvailabe.FirstOrDefault(b => b.Id == selects.select);

                if (BookAvailablee == null)
                {
                    if (int.TryParse(selects.select, out int Number) && Number >= FirstId && Number <= NumbOfBooK.numOfBook)
                    {
                        LoopControl.ContinueLoop = 0;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n**Please try again**\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n**This book has been deleted you cannot perform any actions on it**\n\n**Please try again**\n");
                }
            } while (LoopControl.ContinueLoop == 1);

            LoopControl.ContinueLoop = 1;
            string id = selects.select;
            Book bookToBorrow = Books.FirstOrDefault(b => b.Id == id);

            if (bookToBorrow.remainingQuantity > 0)
            {
                Console.Clear();
                bookToBorrow.remainingQuantity--;
                Console.WriteLine($"A book titled {bookToBorrow.bookTitle} has been borrowed, and the remaining quantity is: {bookToBorrow.remainingQuantity}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("All books of this type are borrowed");
            }
            NumbOfBooK.numOfBook = 0;
        }

        public void ReturnBooks()
        {

            do
            {
                int FirstId = 0;
                NumbOfBooK.numOfBook = 0;
                Console.WriteLine("\nSelect the book you want to return by entering its number:\n");

                foreach (Book book in Books)
                {
                    Console.WriteLine(book.Id + ": " + book.bookTitle);

                    while (LoopControl.ContinueLoop == 1)
                    {
                        FirstId = int.Parse(book.Id);
                        LoopControl.ContinueLoop = 0;
                    }
                    NumbOfBooK.numOfBook++;
                }

                LoopControl.ContinueLoop = 1;
                selects.select = Console.ReadLine();
                Book BookAvailablee = BooksAvailabe.FirstOrDefault(b => b.Id == selects.select);

                if (BookAvailablee == null)
                {
                    if (int.TryParse(selects.select, out int Number) && Number >= FirstId && Number <= NumbOfBooK.numOfBook)
                    {
                        LoopControl.ContinueLoop = 0;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n**Please try again**\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n**This book has been deleted you cannot perform any actions on it**\n\n**Please try again**\n");
                }
            } while (LoopControl.ContinueLoop == 1);

            LoopControl.ContinueLoop = 1;
            string id = selects.select;
            Book bookToReturn = Books.FirstOrDefault(b => b.Id == id);

            if (bookToReturn.remainingQuantity < bookToReturn.quantity)
            {
                Console.Clear();
                bookToReturn.remainingQuantity++;
                Console.WriteLine($"A book titled {bookToReturn.bookTitle} has been returned., and the remaining quantity is: {bookToReturn.remainingQuantity}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("All books of this type are already available, and you cannot return a book that does not belong to the libraryd");
            }
            NumbOfBooK.numOfBook = 0;
        }

        public void CheckBookAvailability()
        {
            do
            {
                int FirstId = 0;
                NumbOfBooK.numOfBook = 0;
                Console.WriteLine("\nSelect the book you want to check its availability by entering its number:\n");

                foreach (Book book in Books)
                {
                    Console.WriteLine(book.Id + ": " + book.bookTitle);

                    while (LoopControl.ContinueLoop == 1)
                    {
                        FirstId = int.Parse(book.Id);
                        LoopControl.ContinueLoop = 0;
                    }
                    NumbOfBooK.numOfBook++;
                }

                LoopControl.ContinueLoop = 1;
                selects.select = Console.ReadLine();
                Book BookAvailablee = BooksAvailabe.FirstOrDefault(b => b.Id == selects.select);

                if (BookAvailablee == null)
                {
                    if (int.TryParse(selects.select, out int Number) && Number >= FirstId && Number <= NumbOfBooK.numOfBook)
                    {
                        LoopControl.ContinueLoop = 0;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n**Please try again**\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n**This book has been deleted you cannot perform any actions on it**\n\n**Please try again**\n");
                }
            } while (LoopControl.ContinueLoop == 1);

            LoopControl.ContinueLoop = 1;
            string id = selects.select;
            Book bookToCheck = Books.FirstOrDefault(b => b.Id == id);

            if (bookToCheck.remainingQuantity > 0)
            {
                Console.Clear();
                Console.WriteLine($"A book titled {bookToCheck.bookTitle} is currently available, and the remaining quantity is: {bookToCheck.remainingQuantity}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("This book is currently unavailable");
            }
            NumbOfBooK.numOfBook = 0;
        }

        public void AddBooks()
        {
            int StrQuantityToIntQuantity = 0;
            int id = 0;

            foreach (Book book in Books)
            {
            id = int.Parse(book.Id);
            }

            id++;

            Console.WriteLine("Enter the book title: ");
            string BookTitle = Console.ReadLine();

            Console.WriteLine("\nEnter the book description: ");
            string Description = Console.ReadLine();

            Console.WriteLine("\nEnter the book quantity: ");
            do
            {
                string Quantity = Console.ReadLine();
                if (int.TryParse(Quantity, out int strQuantityToIntQuantity) && strQuantityToIntQuantity >=0)
                {
                    StrQuantityToIntQuantity = strQuantityToIntQuantity;
                    LoopControl.ContinueLoop = 0;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n**Please try again you did not enter any quantity**\n");
                    Console.WriteLine("\nEnter the book quantity: \n");
                }

            } while (LoopControl.ContinueLoop == 1);

            LoopControl.ContinueLoop = 1;
            Book newBook = new Book(id, BookTitle, Description, StrQuantityToIntQuantity);
            Books.Add(newBook);
            Console.Clear();
            Console.WriteLine($"A new book has been added with the title: {newBook.bookTitle}");
        }

        public void DeleteBooks()
        {
            do
            {
                int FirstId = 0;
                NumbOfBooK.numOfBook = 0;
                Console.WriteLine("\nEnter the number of the book you want to delete:\n ");

                foreach (Book book in Books)
                {
                    Console.WriteLine(book.Id + ": " + book.bookTitle);

                    while (LoopControl.ContinueLoop == 1)
                    {
                        FirstId = int.Parse(book.Id);
                        LoopControl.ContinueLoop = 0;
                    }
                    NumbOfBooK.numOfBook++;
                }

                LoopControl.ContinueLoop = 1;
                selects.select = Console.ReadLine();
                Book BookAvailablee = BooksAvailabe.FirstOrDefault(b => b.Id == selects.select);

                if (BookAvailablee == null)
                {
                    if (int.TryParse(selects.select, out int Number) && Number >= FirstId && Number <= NumbOfBooK.numOfBook)
                    {
                        LoopControl.ContinueLoop = 0;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n**Please try again**\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n**This book has been deleted you cannot perform any actions on it**\n\n**Please try again**\n");
                }
            } while (LoopControl.ContinueLoop == 1);

            LoopControl.ContinueLoop = 1;
            string id = selects.select;
            Book DeleteBook = Books.FirstOrDefault(b => b.Id == id);
            BooksAvailabe.Add(DeleteBook);
            Books.Remove(DeleteBook);
            NumbOfBooK.numOfBook = 0;
            Console.Clear();
            Console.WriteLine($"The book has been deleted: {DeleteBook.bookTitle} ");
            
        }

        public void UpdateBooks()
        {
            do
            {
                int FirstId = 0;
                NumbOfBooK.numOfBook = 0;
                Console.WriteLine("\nEnter the number of the book you want to update:\n ");

                foreach (Book book in Books)
                {
                    Console.WriteLine(book.Id + ": " + book.bookTitle);
                    while (LoopControl.ContinueLoop == 1)
                    {
                        FirstId = int.Parse(book.Id);
                        LoopControl.ContinueLoop = 0;
                    }
                    NumbOfBooK.numOfBook++;
                }

                LoopControl.ContinueLoop = 1;
                selects.select = Console.ReadLine();
                Book BookAvailablee = BooksAvailabe.FirstOrDefault(b => b.Id == selects.select);

                if (BookAvailablee == null)
                {
                    if (int.TryParse(selects.select, out int Number) && Number >= FirstId && Number <= NumbOfBooK.numOfBook)
                    {
                        LoopControl.ContinueLoop = 0;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n**Please try again**\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n**This book has been deleted you cannot perform any actions on it**\n\n**Please try again**\n");
                }
            } while (LoopControl.ContinueLoop == 1);

            LoopControl.ContinueLoop = 1;
            string id = selects.select;
            Book bookToupdate = Books.FirstOrDefault(b => b.Id == id);
            string theBookYouWantToUpdate;

            do
            {
                Console.Clear();

                do
                {
                    Console.WriteLine("What would you like to change:\n\nPress 1 to change the book title\nPress 2 to change the book description\nPress 3 to change the book quantity");
                    theBookYouWantToUpdate = Console.ReadLine();

                    if (theBookYouWantToUpdate == "1")
                    {
                        Console.Clear();
                        Console.WriteLine("\nEnter the new title for the book:");
                        bookToupdate.bookTitle = Console.ReadLine();
                    }
                    else if (theBookYouWantToUpdate == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("\nEnter the new description for the book:");
                        bookToupdate.description = Console.ReadLine();
                    }
                    else if (theBookYouWantToUpdate == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("\nEnter the new quantity for the book:");
                        bookToupdate.quantity = int.Parse(Console.ReadLine());
                        bookToupdate.remainingQuantity = bookToupdate.quantity;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n**Please try again**\n");
                    }
                } while (theBookYouWantToUpdate != "1" && theBookYouWantToUpdate != "2" && theBookYouWantToUpdate != "3");

                Console.Clear();

                do
                {
                    Console.WriteLine("\nIf you still want to modify the same book, press: 1");
                    Console.WriteLine("If you want to move to the next option, press: 2\n");
                    selects.select = Console.ReadLine();

                    if (selects.select == "1")
                    {
                        LoopControl.ContinueLoop = 1;
                    }
                    else if (selects.select == "2")
                    {
                        Console.Clear();
                        LoopControl.ContinueLoop = 0;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n**Please try again**\n");
                    }
                } while (selects.select != "1" && selects.select != "2");
            } while (LoopControl.ContinueLoop == 1);

            LoopControl.ContinueLoop = 1;

        }
    }
    }
    

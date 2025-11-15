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
                Console.WriteLine("Select the book you want to borrow by entering its number:\n");
                foreach (Book book in Books)
                {
                    Console.WriteLine(book.Id + ": " + book.bookTitle);
                }
                selects.select = Console.ReadLine();
                if (selects.select != "1" && selects.select != "2" && selects.select != "3" && selects.select != "4" && selects.select != "5" && selects.select != "6" && selects.select != "7" && selects.select != "8")
                {
                    Console.Clear();
                    Console.WriteLine("\n**Please try again**\n");
                    continue;
                }
                else
                {
                    LoopControl.ContinueLoop = 0;
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
        }

        public void ReturnBooks()
        {

            do
            {
                Console.WriteLine("\nSelect the book you want to return by entering its number:\n");
                foreach (Book book in Books)
                {
                    Console.WriteLine(book.Id + ": " + book.bookTitle);
                }
                selects.select = Console.ReadLine();
                if (selects.select != "1" && selects.select != "2" && selects.select != "3" && selects.select != "4" && selects.select != "5" && selects.select != "6" && selects.select != "7" && selects.select != "8")
                {
                    Console.Clear();
                    Console.WriteLine("\n**Please try again**\n");
                    continue;
                }
                else
                {
                    LoopControl.ContinueLoop = 0;
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
        }

        public void CheckBookAvailability()
        {
            do
            {
                Console.WriteLine("\nSelect the book you want to check its availability by entering its number:\n");

                foreach (Book book in Books)
                {
                    Console.WriteLine(book.Id + ": " + book.bookTitle);
                }
                selects.select = Console.ReadLine();
                if (selects.select != "1" && selects.select != "2" && selects.select != "3" && selects.select != "4" && selects.select != "5" && selects.select != "6" && selects.select != "7" && selects.select != "8")
                {
                    Console.Clear();
                    Console.WriteLine("\n**Please try again**\n");
                    continue;
                }
                else
                {
                    LoopControl.ContinueLoop = 0;
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
        }

        public void AddBooks()
        {
            int id = 0;
            foreach (Book book in Books)
            {
            id = int.Parse(book.Id);
            id++;
            }

            Console.WriteLine("Enter the book title: ");
            string BookTitle = Console.ReadLine();

            Console.WriteLine("\nEnter the book description: ");
            string Description = Console.ReadLine();

            Console.WriteLine("\nEnter the book quantity: ");
            int Quantity = int.Parse(Console.ReadLine());

            Book newBook = new Book(id, BookTitle, Description, Quantity);

            Books.Add(newBook);

            Console.Clear();

            Console.WriteLine($"A new book has been added with the title: {newBook.bookTitle}");
        }

        public void DeleteBooks()
        {
            do
            {
                Console.WriteLine("\nEnter the number of the book you want to delete:\n ");
                foreach (Book book in Books)
                {
                    Console.WriteLine(book.Id + ": " + book.bookTitle);
                }

                selects.select = Console.ReadLine();
                if (selects.select != "1" && selects.select != "2" && selects.select != "3" && selects.select != "4" && selects.select != "5" && selects.select != "6" && selects.select != "7" && selects.select != "8")
                {
                    Console.Clear();
                    Console.WriteLine("\n**Please try again**\n");
                    continue;
                }
                else
                {
                    LoopControl.ContinueLoop = 0;
                }
            } while (LoopControl.ContinueLoop == 1);

            LoopControl.ContinueLoop = 1;

                string id = selects.select;
                Book DeleteBook = Books.FirstOrDefault(b => b.Id == id);

                Books.Remove(DeleteBook);
            Console.WriteLine($"The book has been deleted: {DeleteBook.bookTitle} ");
            
        }

        public void UpdateBooks()
        {
            do
            {
                Console.WriteLine("\nEnter the number of the book you want to update:\n ");
                foreach (Book book in Books)
                {
                    Console.WriteLine(book.Id + ": " + book.bookTitle);
                }

                selects.select = Console.ReadLine();
                if (selects.select != "1" && selects.select != "2" && selects.select != "3" && selects.select != "4" && selects.select != "5" && selects.select != "6" && selects.select != "7" && selects.select != "8")
                {
                    Console.Clear();
                    Console.WriteLine("\n**Please try again**\n");
                    continue;
                }
                else
                {
                    Console.Clear();
                    LoopControl.ContinueLoop = 0;
                }
            } while (LoopControl.ContinueLoop == 1);

            LoopControl.ContinueLoop = 1;

            string id = selects.select;
            Book bookToupdate = Books.FirstOrDefault(b => b.Id == id);

            string theBookYouWantToUpdate;

            do
            {
                do
                {
                    Console.Clear();

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
                        Console.WriteLine("**\nPlease try again**\n");
                    }

                } while (theBookYouWantToUpdate != "1" && theBookYouWantToUpdate != "2" && theBookYouWantToUpdate != "3");

                do
                {
                    Console.Clear();
                    Console.WriteLine("\nIf you still want to modify the same book, press: 1\n");
                    Console.WriteLine("\nIf you want to move to the next option, press: 2\n");

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
                        Console.WriteLine("\n**Please try again**\n");

                } while (selects.select != "1" && selects.select != "2");


            } while (LoopControl.ContinueLoop == 1);

            LoopControl.ContinueLoop = 1;

        }
    }
    }
    

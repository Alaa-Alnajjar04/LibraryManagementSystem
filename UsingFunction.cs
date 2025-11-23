using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace LibraryManagementSystem
{
    internal class UsingFunction
    {
        public static class TransactionData
        {
            public static int TransactionAmount;
        }

        public static class UserAction
        {
            public static string NextAction = " ";
        }

        public static class selects
        {
            public static string select = ""; 
        }

        public static class LoopControl
        {
            public static int ContinueLoop = 1;
        }

        public static class NumbOfBooK
        {
          public static int numOfBook = 0;
        }
       
        public static void DisplayBooksMenu()
        {
            Console.WriteLine("===== Library Menu =====\n");
            Console.WriteLine("Please choose an option from the menu below:\n");
            Console.WriteLine("1. Display All Available Books");
            Console.WriteLine("2. Borrow a Book");
            Console.WriteLine("3. Return a Book");
            Console.WriteLine("4. Check Book Availability");
            Console.WriteLine("5. Add a book");
            Console.WriteLine("6. Delete a book");
            Console.WriteLine("7. Update the book");
            Console.WriteLine("8. Exit");
            Console.WriteLine("\nEnter the number of your choice: ");
        }

        public static void GetDisplayAllAvailableBooksNextAction()
        {
            do 
            {
                Console.WriteLine("\nIf you want to perform another operation, press: $");
                Console.WriteLine("If you want to exit the library system, press: *");
                UserAction.NextAction = Console.ReadLine();
                if (UserAction.NextAction != "*"  && UserAction.NextAction != "$")
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
        }

       

        public static void GetBorrowNextAction()
        {
            do
            {
                Console.WriteLine("\nIf you want to borrow another book, press: #");
                Console.WriteLine("If you want to perform another operation, press: $");
                Console.WriteLine("If you want to exit the library system, press: *");
                UserAction.NextAction = Console.ReadLine();
                if (UserAction.NextAction != "*" && UserAction.NextAction != "#" && UserAction.NextAction != "$")
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
        }

        public static void GetReturnNextAction()
        {
            do
            {
                Console.WriteLine("\nIf you want to return another book, press: #");
                Console.WriteLine("If you want to perform another operation, press: $");
                Console.WriteLine("If you want to exit the library system, press: *");
                UserAction.NextAction = Console.ReadLine();
                if (UserAction.NextAction != "*" && UserAction.NextAction != "#" && UserAction.NextAction != "$")
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
        }

        public static void GetCheckAvailabilityNextAction()
        {
            do
            {
                Console.WriteLine("\nIf you want to check the availability of another book, press: #");
                Console.WriteLine("If you want to perform another operation, press: $");
                Console.WriteLine("If you want to exit the library system, press: *");
                UserAction.NextAction = Console.ReadLine();
                if (UserAction.NextAction != "*" && UserAction.NextAction != "#" && UserAction.NextAction != "$")
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
        }

        public static void GetAddABooksNextAction()
        {
            do
            {
                Console.WriteLine("\nIf you want to add another book, press: #");
                Console.WriteLine("If you want to perform another operation, press: $");
                Console.WriteLine("If you want to exit the library system, press: *");
                UserAction.NextAction = Console.ReadLine();
                if (UserAction.NextAction != "*" && UserAction.NextAction != "#" && UserAction.NextAction != "$")
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
        }

        public static void GetDeleteABooksNextAction()
        {
            do
            {
                Console.WriteLine("\nIf you want to delete another book, press: #");
                Console.WriteLine("If you want to perform another operation, press: $");
                Console.WriteLine("If you want to exit the library system, press: *");
                UserAction.NextAction = Console.ReadLine();
                if (UserAction.NextAction != "*" && UserAction.NextAction != "#" && UserAction.NextAction != "$")
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
        }

        public static void GetUpdateeABooksNextAction()
        {
            do
            {
                Console.WriteLine("\nIf you want to update something else in the same book or modify another book, press: #");
                Console.WriteLine("If you want to perform another operation, press: $");
                Console.WriteLine("If you want to exit the library system, press: *");
                UserAction.NextAction = Console.ReadLine();
                if (UserAction.NextAction != "*" && UserAction.NextAction != "#" && UserAction.NextAction != "$")
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
        }

    }
}

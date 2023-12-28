using System;
using System.Collections.Generic;


namespace MyLibrary_1
{
    internal static class Manager
    {
        // Manager 

        // Get Book Details
        public static Book IpuntBook()
        {
            Book b = new Book();
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter Number Book : ");
                    string a = Console.ReadLine();
                    if (a != "")
                    {
                        b.Number = a;
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter Book Name : ");
                    string a = Console.ReadLine();
                    if (a != "")
                    {
                        b.Name = a; break;
                    }
                }
                Console.WriteLine("Enter Writer : ");
                b.Writer = Console.ReadLine();
                Console.WriteLine("Enter Issue : ");
                b.Issue = Console.ReadLine();
                Console.WriteLine("Enter Group : ");
                b.Grouping = Console.ReadLine();
                b.IsAvailable = true;
                return b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter the correct value ...!");
                Console.ResetColor();
                //Console.WriteLine("If you cancel the entry of the book, enter the number -1 ...!");
                //Console.WriteLine("َOtherwise, press a key : ");
                //if (Console.ReadLine() == "-1")
                //{
                //    return null;
                //}
                return null;
            }

        }

        // Show List Books
        public static void GetListAllBook()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nList Books : \n");
                foreach (var i in BookManager.bookList)
                {
                    Console.WriteLine($"Book Number : {i.Number}");
                    Console.WriteLine($"Book Name : {i.Name}");
                    Console.WriteLine($"Book Writer : {i.Writer}");
                    Console.WriteLine($"Book Issue : {i.Issue}");
                    Console.WriteLine($"Book Group : {i.Grouping}");
                    Console.WriteLine($"IsAvailable : {i.IsAvailable}");
                    Console.WriteLine("*******************************************");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.ResetColor();
            }

        }

        // Show List Borrowed 
        public static void GetListAllBorrowedBook()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nList Borroweds : \n");
                foreach (var i in BookManager.borowedList)
                {
                    string usernumber = "every one ! ";
                    foreach (var j in UserManager.Users)
                    {
                        if (j.BorrowedBooksNumbesr == i.Number)
                            usernumber = j.Number;
                    }
                    Console.WriteLine($"Book Number : {i.Number}");
                    Console.WriteLine($"Book Name : {i.Name}");
                    Console.WriteLine($"Book Writer : {i.Writer}");
                    Console.WriteLine($"Book Issue : {i.Issue}");
                    Console.WriteLine($"Book Group : {i.Grouping}");
                    Console.WriteLine($"IsAvailable : {i.IsAvailable}");
                    Console.WriteLine($"User Number Borrow : {usernumber}");
                    Console.WriteLine("*******************************************");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.ResetColor();
            }
        }

        // Get User Details
        public static User IpnutUser()
        {
            User b = new User();
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter Number : ");
                    string a = Console.ReadLine();
                    if (a != "")
                    {
                        b.Number = a;
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter Name : ");
                    string a = Console.ReadLine();
                    if (a != "")
                    {
                        b.Name = a; break;
                    }
                }
                Console.WriteLine("Enter Email : ");
                b.Email = Console.ReadLine();
                return b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter the correct value ...!");
                Console.ResetColor();
                //Console.WriteLine("If you cancel the entry of the book, enter the number -1 ...!");
                //Console.WriteLine("َOtherwise, press a key : ");
                //if (Console.ReadLine() == "-1")
                //{
                //    return null;
                //}
                return null;
            }
        }

        // Show List User
        public static void GetListAllUser()
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nList Users : \n");
                foreach (var i in UserManager.Users)
                {
                    Console.WriteLine($"User Number : {i.Number}");
                    Console.WriteLine($"User Name : {i.Name}");
                    Console.WriteLine($"User Email : {i.Email}");
                    Console.WriteLine($"Book Borrowed : {i.BorrowedBooksNumbesr}");

                    Console.WriteLine("*******************************************");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.ResetColor();
            }
        }

        // Show Result Search Book
        public static void GetListSearchBook(List<Book> bookList)
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nResult Search : \n");
                foreach (var i in bookList)
                {
                    Console.WriteLine($"Book Number : {i.Number}");
                    Console.WriteLine($"Book Name : {i.Name}");
                    Console.WriteLine($"Book Writer : {i.Writer}");
                    Console.WriteLine($"Book Issue : {i.Issue}");
                    Console.WriteLine($"Book Group : {i.Grouping}");
                    Console.WriteLine($"IsAvailable : {i.IsAvailable}");
                    Console.WriteLine("*******************************************");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.ResetColor();
            }
        }

        // Show Result Search User
        public static void GetListSearchUser(List<User> userList)
        {
            try
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\nSearch Result : \n");
                foreach (var i in userList)
                {
                    Console.WriteLine($"User Number : {i.Number}");
                    Console.WriteLine($"User Name : {i.Name}");
                    Console.WriteLine($"User Email : {i.Email}");
                    Console.WriteLine($"Book Borrowed : {i.BorrowedBooksNumbesr}");

                    Console.WriteLine("*********************************************");
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.ResetColor();
            }
        }
    }
}

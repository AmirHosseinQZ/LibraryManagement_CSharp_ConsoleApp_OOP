using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace MyLibrary_1
{
    internal class BookManager : IBookManager
    {
        //Book List
        public static List<Book> bookList = new List<Book>();
        // List of Borrowed Books
        public static List<Book> borowedList = new List<Book>();

        // Delete Book 
        public bool DeleteBook(string bookNumber)
        {
            foreach (Book i in bookList)
            {
                if (i.Number == bookNumber)
                {
                    foreach (var j in UserManager.Users)
                    {
                        if (j.BorrowedBooksNumbesr == i.Number)
                        {
                            j.BorrowedBooksNumbesr = "";
                        }
                    }
                    bookList.Remove(i);
                    return true;
                }
            }
            return false;
        }

        // Delete Borrowed Book
        public bool DeleteBorrow(string bookNumber)
        {
            foreach (Book i in borowedList)
            {
                if (i.Number == bookNumber)
                {
                    borowedList.Remove(i);
                    i.IsAvailable = true;
                    return true;
                }
            }
            return false;
        }

        //Add Book
        public bool InsertBook(Book book)
        {
            try
            {
                bookList.Add(book);
                return true;
            }
            catch { return false; }
        }

        // Add Borrowe
        public bool InsertBorrow(string bookNumber, string userNumber)
        {
            foreach (User j in UserManager.Users)
            {
                if (j.Number == userNumber)
                {
                    foreach (Book i in bookList)
                    {
                        if (i.Number == bookNumber)
                        {
                            i.IsAvailable = false;
                            borowedList.Add(i);
                            j.BorrowedBooksNumbesr = i.Number;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        //Search Book With Number Book
        public List<Book> SearchBookWithNumberBook(string bookNumber)
        {
            List<Book> list = new List<Book>();
            foreach (Book i in bookList)
            {
                if (i.Number == bookNumber)
                    list.Add(i);
            }
            return list;
        }

        // Search Book With Book Name
        public List<Book> SearchBookWithBookName(string bookName)
        {
            List<Book> list = new List<Book>();
            foreach (Book i in bookList)
            {
                if (i.Name == bookName)
                    list.Add(i);
            }
            return list;
        }
    }
}

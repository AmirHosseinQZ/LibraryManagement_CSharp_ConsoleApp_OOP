using System;
using System.Collections.Generic;


namespace MyLibrary_1
{
    internal interface IBookManager
    {
        // InterFace : Book Manager

        // Add Book
        bool InsertBook(Book book);

        // Delete Book
        bool DeleteBook(string bookNumber);

        // Add Borrow
        bool InsertBorrow(string bookNumber , string userNumber);

        // Delete Borrow
        bool DeleteBorrow(string bookNumber);

        // Search Book With Number Book
        List<Book> SearchBookWithNumberBook(string bookNumber);

        // Search Book With Book Name
        List<Book> SearchBookWithBookName(string bookName);
    }
}

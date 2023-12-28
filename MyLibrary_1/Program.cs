using System;

namespace MyLibrary_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*******************************
            // Amir Hossain Ghaemi Zadeh
            //*******************************

            BookManager bookManager = new BookManager();
            UserManager userManager = new UserManager();

            /////////////////////////////////////////

            //Add Defult Book
            Book a = new Book() { Name = "Book1", Number = "a1", Writer = "AmHA", Issue = "aa", Grouping = "roman", IsAvailable = true };
            Book b = new Book() { Name = "Book2", Number = "b1", Writer = "ALHA", Issue = "bb", Grouping = "classic", IsAvailable = true };
            Book c = new Book() { Name = "Book3", Number = "c1", Writer = "MHHA", Issue = "cc", Grouping = "story", IsAvailable = true };
            bookManager.InsertBook(a);
            bookManager.InsertBook(b);
            bookManager.InsertBook(c);

            // Add Defult User
            User d = new User() { Name = "ReyhaneVajdi", Number = "dd1", Email = "reyhane@gamil.com" };
            User e = new User() { Name = "MarayamAllahi", Number = "ee2", Email = "maryam@gamil.com" };
            User f = new User() { Name = "RezaRazeii", Number = "ff3", Email = "reza@gamil.com" };
            userManager.InsertUser(d);
            userManager.InsertUser(e);
            userManager.InsertUser(f);

            //////////////////////////////////////
            while (true)
            {
                // Manager panel
                Console.WriteLine("-------------------------------------------------------------------------\n");
                Console.WriteLine("Please enter a section for administration : ");
                Console.WriteLine("1 -> Manage Book.");
                Console.WriteLine("2 -> Manage User.");
                Console.WriteLine("3 -> Exit");
                Console.Write("\n-----Number-----> ");

                switch (Console.ReadLine())
                {
                    // Book Panel
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Choose one of the following operation : ");
                        Console.WriteLine("1 -> Add Book.");
                        Console.WriteLine("2 -> Delete Book.");
                        Console.WriteLine("3 -> Add Borrow Book.");
                        Console.WriteLine("4 -> List Book.");
                        Console.WriteLine("5 -> List Borrowed Book.");
                        Console.WriteLine("6 -> Return Book to Library.");
                        Console.WriteLine("7 -> Search Book With Name.");
                        Console.WriteLine("8 -> Search Book With Number.");
                        Console.WriteLine("9 -> Back to menu.");
                        Console.Write("\n-----Number-----> ");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                ErorrProvider("book", bookManager.InsertBook(Manager.IpuntBook()), "Added");
                                break;
                            case "2":
                                Console.Write("     Please enter the book number ---> ");
                                string n = Console.ReadLine();
                                ErorrProvider("book", bookManager.DeleteBook(n), "Deleted");
                                break;
                            case "3":
                                Console.Write("     Please enter the book number ---> ");
                                string booknum = Console.ReadLine();
                                Console.Write("     Please enter the user number ---> ");
                                string usernum = Console.ReadLine();
                                ErorrProvider("book", bookManager.InsertBorrow(booknum, usernum), "Borrowed");
                                break;
                            case "4":
                                Manager.GetListAllBook();
                                break;
                            case "5":
                                Manager.GetListAllBorrowedBook();
                                break;
                            case "6":
                                Console.Write("     Please enter the book number ---> ");
                                string num = Console.ReadLine();
                                ErorrProvider("book", bookManager.DeleteBorrow(num), "Delete Borrow");
                                break;
                            case "7":
                                Console.Write("     Please enter the book name ---> ");
                                string bookName = Console.ReadLine();
                                Manager.GetListSearchBook(bookManager.SearchBookWithBookName(bookName));
                                break;
                            case "8":
                                Console.Write("     Please enter the book number ---> ");
                                string bookNumber = Console.ReadLine();
                                Manager.GetListSearchBook(bookManager.SearchBookWithNumberBook(bookNumber));
                                break;
                            case "9":
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("The Operation :");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Please enter the correct value ...!");
                                Console.ResetColor();
                                break;
                        }
                        break;

                    // User Panel
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Choose one of the following operation : ");
                        Console.WriteLine("1 -> Add User.");
                        Console.WriteLine("2 -> Delete User.");
                        Console.WriteLine("3 -> List User.");
                        Console.WriteLine("4 -> Search Book With Name.");
                        Console.WriteLine("5 -> Search Book With Number.");
                        Console.WriteLine("6 -> Back to menu.");
                        Console.Write("\n-----Number-----> ");
                        switch (Console.ReadLine())
                        {
                            case "1":
                                ErorrProvider("user", userManager.InsertUser(Manager.IpnutUser()), "Added");
                                break;
                            case "2":
                                Console.Write("     Please enter the user number ---> ");
                                string unum = Console.ReadLine();
                                ErorrProvider("usre", userManager.DeleteUser(unum), "Deleted");
                                break;
                            case "3":
                                Manager.GetListAllUser();
                                break;
                            case "4":
                                Console.Write("     Please enter the user name ---> ");
                                string nameUser = Console.ReadLine();
                                Manager.GetListSearchUser(userManager.SearchUserWithNameUser(nameUser));
                                break;
                            case "5":
                                Console.Write("     Please enter the user number ---> ");
                                string numberUser = Console.ReadLine();
                                Manager.GetListSearchUser(userManager.SearchUserWithNumberUser(numberUser));
                                break;
                            case "6":
                                Console.Clear();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("The Operation :");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Please enter the correct value ...!");
                                Console.ResetColor();
                                break;
                                break;
                        }
                        break;

                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("The Operation :");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter the correct value ...!");
                        Console.ResetColor();
                        break;
                }
            }
        }

        //Error Manager
        static void ErorrProvider(string name, bool IsValid, string operation)
        {
            if (IsValid)
            {
                Console.Clear();
                Console.WriteLine("The Operation : ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"@ The {name} has been successfully {operation} @");
                Console.ResetColor();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("The Operation : ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error occurred. Please try again ...!");
                Console.ResetColor();
            }
        }
    }
}

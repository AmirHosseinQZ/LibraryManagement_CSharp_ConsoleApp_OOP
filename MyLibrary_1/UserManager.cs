using System;
using System.Collections.Generic;

namespace MyLibrary_1
{
    internal class UserManager : IUserManager
    {
        // User List
        public static List<User> Users = new List<User>();

        // Delete User
        public bool DeleteUser(string userNumber)
        {
            try
            {
                foreach (var i in Users)
                {
                    if (i.Number == userNumber)
                    {
                        foreach (var j in BookManager.borowedList)
                        {
                            if (i.BorrowedBooksNumbesr == j.Number)
                            {
                                j.IsAvailable = true;
                            }
                        }
                        Users.Remove(i);
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Get Details User
        public bool InsertUser(User user)
        {
            try
            {
                Users.Add(user);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        // Search User With Name User
        public List<User> SearchUserWithNameUser(string userName)
        {
            try
            {
                List<User> u = new List<User>();
                foreach (var i in Users)
                {
                    if (i.Name == userName)
                    {
                        u.Add(i);
                    }
                }
                return u;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }

        // Search User With Number User
        public List<User> SearchUserWithNumberUser(string userNumber)
        {
            try
            {
                List<User> u = new List<User>();
                foreach (var i in Users)
                {
                    if (i.Number == userNumber)
                    {
                        u.Add(i);
                    }
                }
                return u;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}

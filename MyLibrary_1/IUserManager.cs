using System;
using System.Collections.Generic;


namespace MyLibrary_1
{
    internal interface IUserManager
    {
        // Interface : User Manager

        // Add User
        bool InsertUser(User user);

        // Delete User
        bool DeleteUser(string userNumber);

        // Search User With Number User
        List<User> SearchUserWithNumberUser(string userNumber);

        // Search User With Name User 
        List<User> SearchUserWithNameUser(string userName);
    }
}

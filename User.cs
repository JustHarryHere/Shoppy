using System;
using System.Collections.Generic;

namespace Shoppy
{
    // User class
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Basket Basket { get; set; }

        public User(int userId, string username, string email)
        {
            UserId = userId;
            Username = username;
            Email = email;
            Basket = new Basket();
        }
    }

}

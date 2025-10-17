using System;
using System.Collections.Generic;

namespace Shoppy
{
    // User class
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Basket Basket { get; set; }

        public User()
        {
            UserId = 0;
            Username = string.Empty;
            Password = string.Empty;
            Basket = new Basket();
        }

        public User(int userId, string username, string password)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Basket = new Basket();
        }


    }

    public class Admin : User
    {
        public Admin() : base()
        {
        }

        public Admin(int userId, string username, string password): base(userId, username, password)
        { 
            UserId = userId;
            Username = username;
            Password = password;
            Basket = new Basket();
        } 

        public void RemoveItem(SetItem item)
        {
            JsonManager.RemoveItemFromJson(item);
        }
    }

    public class Users : List<User>
    {
        public void GetUsersFromJson()
        {

        }
        public void RemoveUser(User user)
        {
            this.Remove(user);
        }
    }

}

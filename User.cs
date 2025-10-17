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
        public int SecurityLevel { get; set; }

        public User(int userId, string username, string password)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Basket = new Basket();
            SecurityLevel = 0;
        }

        public void SaveUser()
        {
            // Code to save user details to a database or file
        }

        public void SignUp(int userid, string username, string password)
        {
            User user = new User(userid, username, password);
            user.SaveUser();

        }


    }

    public class Admin : User
    {
        public Admin(int userId, string username, string password): base(userId, username, password)
        { 
            UserId = userId;
            Username = username;
            Password = password;
            Basket = new Basket();
        } 

        public void RemoveItem(SetItem item)
        {
            JsonManager.RemoveItemFromJson(@"data\items.json", item);
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

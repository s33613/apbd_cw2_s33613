using System;
using System.Collections.Generic;

namespace Console_Application
{
    public class User
    {
        private static List<User> userList = new List<User>();
        private string name {get; set;}
        private string password { get; set;}

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
            userList.Add(this);
        }

        public void Login(string username,string password)
        {
            User u = userList.Find(user => user.name == username);
            if (u != null)
            {
                if(u.password == password) {
                    Console.WriteLine("successfully logged in");
                }
                else {
                    Console.WriteLine("Invalid password");
                }
            }
            else{
                Console.WriteLine("Cannot find user with this username");
            }
        }
    }
}
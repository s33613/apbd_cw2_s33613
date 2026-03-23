using System;
using System.Collections.Generic;

namespace Console_Application
{
    public abstract partial class User {
        private static List<User> userList = new List<User>();
        private RentingManager rentingManager;
        private string name {get; set;}
        public int rentLimit;
        private string password { get; set;}

        public User(string name, string password) {
            this.name = name;
            this.password = password;
            userList.Add(this);
            this.rentingManager = new RentingManager(this);
        }

        public static RentingManager Login(string username,string password) {
            User u = userList.Find(user => user.name == username);
            if (u != null) {
                if(u.password == password) {
                    return u.rentingManager;
                }
                else {
                    throw new Exception("Password is incorrect");
                }
            }
            else
            {
                throw new Exception("Username is incorrect");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace Console_Application
{
    public class RentingManager
    {
        List<Rent> currentRents = new List<Rent>();
        List<User> archivedRents = new List<User>();
        User user;
        public RentingManager(User user) {
            this.user = user;
        }

        public void AddRent(Item item, DateTime rentDate, DateTime returnDate) {
            if (item.isAvailable) {
                currentRents.Add(new Rent(rentDate,returnDate,0,user, item));
                item.Rent();
                Console.WriteLine(item.name + " has been rented");
            }
            else {
                throw new Exception("Item not available");
            }
        }

        public void ReturnItem(Item item)
        {
            bool removed = false;
            foreach (Rent rent in currentRents)
            {
                if (rent.item == item)
                {
                    removed = true;
                    archivedRents.Add(rent.user);
                    currentRents.Remove(rent);
                }
            }
            if (removed) {
                Console.WriteLine(item.name + " has been returned");
            }
            else {
                Console.WriteLine("Item has not been rented returned");
            }
        }
    }
}
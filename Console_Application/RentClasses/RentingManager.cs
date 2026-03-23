using System;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace Console_Application
{
    public class RentingManager
    {
        public List<Rent> currentRents { get; private set; }
        public List<Rent> archivedRents{ get; private set; }
        User user;
        public RentingManager(User user) {
            this.user = user;
            currentRents = new List<Rent>();
            archivedRents = new List<Rent>();
        }

        public void AddRent(Item item, DateTime rentDate, DateTime returnDate) {
            if (item.isAvailable) {
                if (user.rentLimit > currentRents.Count)
                {
                    currentRents.Add(new Rent(rentDate, returnDate, 0, user, item));
                    Console.WriteLine(item.name + " has been rented");
                }
                else
                {
                    throw new Exception("Too many rents");
                }
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
                if (rent.item.Equals(item))
                {
                    removed = true;
                    archivedRents.Add(rent);
                    currentRents.Remove(rent);
                    rent.item.Return();
                    break;
                }
            }
            if (removed) {
                Console.WriteLine(item.name + " has been returned");
            }
            else {
                Console.WriteLine("Item has not been rented ");
            }
        }
    }
}
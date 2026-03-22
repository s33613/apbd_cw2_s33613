using System;

namespace Console_Application
{
    public class Rent
    {
        private DateTime rentedFrom;
        private DateTime rentedUntil;
        Item item;
        private int cost;
        private User user;

        public Rent(DateTime rentedFrom, DateTime rentedUntil, int cost, User user, Item item) {
            this.rentedFrom = rentedFrom;
            this.rentedUntil = rentedUntil;
            this.cost = cost;
            this.user = user;
            if(item.isAvailable) {
                this.item = item;
                this.item.Rent();
            }
            else {
                Console.WriteLine("Item not available"); // TODO: make an exception
            }
        }


    }
}
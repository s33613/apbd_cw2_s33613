using System;

namespace Console_Application
{
    public class Rent
    {
        public  DateTime rentedFrom{get; private set; }
        public  DateTime rentedUntil{get; private set; }
        public Item item{get; private set; }
        public  int cost{get; private set; }
        public  User user{get; private set; }

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
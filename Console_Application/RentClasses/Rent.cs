using System;

namespace Console_Application
{
    public class Rent
    {
        public DateTime rentedFrom{get; private set; }
        public DateTime rentedUntil{get; private set; }
        public DateTime returnDate{get; private set;}
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
            else
            {
                throw new Exception("item not available");
            }
        }

        public override string ToString()
        {
            return "rented From: "+ rentedFrom + " to " + rentedUntil + " cost " + cost + " item: " + item;
        }

        public void Return(DateTime ret)
        {
            returnDate = ret;
            if (returnDate > rentedUntil)
            {
                
                cost = new Random().Next(1, 50);
                Console.WriteLine("Returned after due date, additional fee: " + cost);
            }
        }
    }
}
using System;
using System.Xml.Schema;

namespace Console_Application
{
    public abstract class Item
    {
        private string name { get; set;}
        private string description { get; set;}
        public bool isAvailable { get; private set; }

        public Item(string nameP, string descriptionP)
        {
            name = nameP;
            description = descriptionP;
            isAvailable = true;
        }

        public void Return()
        {
            if (!isAvailable)
            {
                Console.WriteLine("Item " + name + " has been Returned");
                isAvailable = true;
            }
            else
            {
                Console.WriteLine("Item " + name + " is already in Store");
            }
        }

        public void Rent()
        {
            if (isAvailable)
            {
                Console.WriteLine("Item " + name + " has been Rented");
                isAvailable = false;
            }
            else
            {
                Console.WriteLine("Item " + name + " is already in Rented");
            }

        }
    }
}
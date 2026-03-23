using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Console_Application
{
    public abstract class Item
    {
        public static List<Item> items = new List<Item>();
        public string name { get; private set;}
        public string description { get; private set;}
        public bool isAvailable { get; private set; }

        public Item(string nameP, string descriptionP)
        {
            name = nameP;
            description = descriptionP;
            isAvailable = true;
            items.Add(this);
        }

        public void Return()
        {
            if (!isAvailable)
            {
                isAvailable = true;
            }
            else
            {
                throw new Exception(name + " is already in stock");
            }
        }

        public void Rent()
        {
            if (isAvailable)
            {
                isAvailable = false;
            }
            else
            {
                throw new Exception(name + " is already rented");
            }

        }

        public override string ToString()
        {
            return this.name + " " + this.description;
        }
    }
}
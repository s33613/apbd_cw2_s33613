using System;

namespace Console_Application
{
    public class Laptop : Item
    {
        public string data {get; private set; }

        public Laptop(string desc) : base("Laptop",desc)
        {
            this.data = "";
        }

        public void AddData(String data)
        {
            this.data += data;
        }

        public void RemoveData()
        {
            this.data = "";
        }
    }
}
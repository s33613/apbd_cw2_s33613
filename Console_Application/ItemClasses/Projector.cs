using System;

namespace Console_Application
{
    public class Projector : Item
    {
        public Projector(string desc) : base("Projector",desc)
        {
        }

        public void Project()
        {
            Console.WriteLine("Projecting an image");
        }
    }
}
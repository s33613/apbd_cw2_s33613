using System;

namespace Console_Application
{
    public class Projector : Item
    {
        public Projector(string desc) : base("Projector",desc)
        {
        }

        public static void Show()
        {
            Console.WriteLine("Projecting an image");
        }
    }
}
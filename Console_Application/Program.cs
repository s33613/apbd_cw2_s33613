using System;
using Console_Application;
using Console_Application.Properties;

class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student("Mike", "SecuredPass");
            Employee e = new Employee("JohnWorker", "Password");
            Camera c1 = new Camera("C350");
            c1.TakePhoto();
            Camera c2 = new Camera("C400");
            c2.TakePhoto();
            c2.TakePhoto();
            Camera c3 = new Camera("C505");
            Laptop l1 = new Laptop("Lenovo");
            l1.AddData("Workfile");
            Laptop l2 = new Laptop("Asus");
            l2.AddData("GameDownload");
            Laptop l3 = new Laptop("Dell");
            l3.AddData("JDK");
            Projector p1 = new Projector("P250");
            Projector p2 = new Projector("P90");
            Projector p3 = new Projector("P360");
            RentingManager rm = User.Login("Mike", "SecuredPass");
            rm.AddRent(p1, new DateTime(2026,1,14),new DateTime(2026,1,20));
            rm.AddRent(l1, new DateTime(2026,1,14),new DateTime(2026,1,20));
            rm.AddRent(c1, new DateTime(2026,1,14),new DateTime(2026,1,20));
            
            
            
        }
    }

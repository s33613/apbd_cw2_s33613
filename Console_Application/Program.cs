using System;
using Console_Application;
using Console_Application.Properties;

class Program
    {
        public static void Main(string[] args)
        {
            Student s = new Student("Mike", "SecuredPass");
            Employee emp = new Employee("JohnWorker", "Password");
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
            rm =  User.Login("JohnWorker", "Password");
            rm.AddRent(l2, new DateTime(2026,1,17),new DateTime(2026,1,22));
            rm.AddRent(l3, new DateTime(2026,1,10),new DateTime(2026,1,22));
            rm.AddRent(p2, new DateTime(2026,1,20),new DateTime(2026,1,20));
            rm.ReturnItem(p2);
            bool work = true;
            RentingManager cRm = null;
            while (work) {
                if (cRm == null) {
                    Console.WriteLine("Write your username");
                    string username = Console.ReadLine();
                    Console.WriteLine("Write your password");
                    string password = Console.ReadLine();
                    try {
                        cRm = User.Login(username, password);
                    }
                    catch (Exception e) {
                        Console.WriteLine(e);
                    }
                }
                else
                {
                    Console.WriteLine("Select option");
                    Console.WriteLine("-2. Quit");
                    Console.WriteLine("-1. Log out");
                    Console.WriteLine("1. Rent an item");
                    Console.WriteLine("2. Return an item");
                    Console.WriteLine("3. Check rented items");
                    Console.WriteLine("4. Check archived rents");
                    string answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "-2" :{
                            work = false;
                            break;
                        } ;
                        case "-1" :{
                            cRm = null;
                            break;
                        } ;
                        case "1": {
                            Console.WriteLine("Select Item to Rent");
                            for (int i = 0; i < Item.items.Count; i++) {
                                if (Item.items[i].isAvailable == true) {
                                    Console.WriteLine(i + " " + Item.items[i]);
                                }
                            }
                            int input = int.Parse(Console.ReadLine());
                            DateTime rentDate = DateTime.Today;
                            Console.WriteLine("Write date of return");
                            DateTime retDate = DateTime.Parse(Console.ReadLine());
                            try
                            {
                                cRm.AddRent(Item.items[input], rentDate, retDate);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e);
                            }

                            break;
                        }
                        case "2":
                        {
                            Console.WriteLine("Select Item to Return");
                            for(int i = 0; i < cRm.currentRents.Count; i++){
                                Console.WriteLine(i + " " +cRm.currentRents[i].item);
                            }
                            int input = int.Parse(Console.ReadLine());
                            cRm.ReturnItem(cRm.currentRents[input].item);
                            break;
                        }
                        case "3": {
                                foreach (var rent in cRm.currentRents)
                                {
                                    Console.WriteLine(rent);
                                }

                                break;
                            }
                        case "4":{
                            foreach (var rent in cRm.archivedRents)
                            {
                                Console.WriteLine(rent);
                            }

                            break;
                        }
                        }

                }


            }
        }


    }


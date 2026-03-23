namespace Console_Application
{
    public class Employee : User
    {
        

        public Employee(string name, string password) : base(name, password)
        {
            this.rentLimit = 5;
        }

    }
}
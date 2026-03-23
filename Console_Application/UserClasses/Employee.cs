namespace Console_Application
{
    public class Employee : User
    {
        private int rentLimit;

        public Employee(string name, string password) : base(name, password)
        {
            this.rentLimit = 5;
        }

    }
}
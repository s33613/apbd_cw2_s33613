namespace Console_Application
{
    public class Student : User
    {
        private int rentLimit;
        Student(string name, string password) : base(name, password)
        {
            this.rentLimit = 2;
        }
    }
}
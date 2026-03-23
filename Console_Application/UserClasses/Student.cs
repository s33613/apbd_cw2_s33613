namespace Console_Application
{
    public class Student : User
    {
        public Student(string name, string password) : base(name, password)
        {
            this.rentLimit = 2;
        }
    }
}
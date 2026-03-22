namespace Console_Application
{
    public class User
    {
        public string name {get; set;}
        private string password { get; set;}

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
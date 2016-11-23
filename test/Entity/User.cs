namespace test.Entity
{
    public class User
    {
        public static readonly User DEFAULT_CONTACT = new User("tomsmith", "SuperSecretPassword!");

        private string _name;
        private string _password;
        public string Name { get { return _name; } set { _name = value; } }
        public string Password { get { return _password; } set { _password = value; } }


        public User(string firstName, string lastName)
        {
            _name = firstName;
            _password = lastName;

        }
    }
}
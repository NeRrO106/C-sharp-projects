using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable
    {
        private string password;
        private string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length >= 8) { password = value; }
            }
        }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }
        public void Reset()
        {
            Hidden = false;
            Password = "null";
        }
        public bool ChangePassword(string oldpass, string newpass)
        {
            if (oldpass == Password && newpass.Length >= 8)
            {
                Password = newpass;
                return true;
            }
            else
            {
                return false;
            }
        }
        void HeaderSymbol()
        {
            Console.WriteLine("Password");
            Console.WriteLine("--------");
        }
        public void Display()
        {
            HeaderSymbol();
            if (Hidden == false)
            {
                Console.WriteLine(Password);
            }
            else
            {
                Console.WriteLine("********");
            }
        }
    }
}
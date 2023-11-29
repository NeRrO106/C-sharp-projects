using System;

namespace SavingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");

            PasswordManager pm = new PasswordManager("iluvpi", true);
            tdl.Display();
            pm.Display();

            tdl.Reset();
            pm.Reset();

            tdl.Display();
            pm.Display();

            PasswordManager pm2 = new PasswordManager("parola1234", false);
            pm2.Display();
            pm2.ChangePassword("parola1234", "parolanoua1234");
            pm2.Display();

        }
    }
}

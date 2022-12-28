using ServiceLayer.Services;

namespace Homework_1.Controller
{
    internal class AccountController
    {
        public void Login()
        {
            Account account = new Account();
            Console.WriteLine("Enter email address:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            int roleId = 1;

            var result = account.Login(email, password, roleId);
            Console.WriteLine(result);
        }
    }
}

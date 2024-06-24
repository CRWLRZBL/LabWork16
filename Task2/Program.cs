using System.Reflection.Metadata;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new() { Login = "User1", Password = "12345678" };

            user1.PropertyChanged += 

            user1.Login = "NewUser";
            user1.Password = "password";

            user1.Login = "NewUser";
            user1.Password = "password";
        }

        
    }
}

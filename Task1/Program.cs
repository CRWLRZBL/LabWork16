using System.ComponentModel;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new() { Login = "User1", Password = "12345678" };

            user1.PropertyChanged += User_PropertyChanged;

            user1.Login = "NewUser";
            user1.Password = "password";

            user1.Login = "NewUser";
            user1.Password = "password";
        }

        static void User_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            Console.WriteLine($"{e.PropertyName} изменено");
        }
    }
}

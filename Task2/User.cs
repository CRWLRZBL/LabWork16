using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class User
    {
        event EventHandler? Notify;

        private string login;
        private string password;

        public string Login
        {
            get => login;
            set
            {
                if (login != value && !string.IsNullOrWhiteSpace(value))
                {
                    login = value;                   
                    
                }
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (password != value && !string.IsNullOrWhiteSpace(value))
                {
                    password = value;
                }
            }
        }
        Notify?.Invoke(this, EventArgs.Empty);
    }
}

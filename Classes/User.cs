using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progress_Manager.Classes
{
    [Serializable]
    class User : Person
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        public User() : base()
        {
            Login = "";
            Password = "";
            Email = "";
        }

        public User(string login, string password, string email) : base()
        {
            this.Login = login;
            this.Password = password;
            this.Email = email;
        }
    }
}

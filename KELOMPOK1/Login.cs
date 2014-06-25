using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KELOMPOK1
{
    class Login
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool SetLogin(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;

            if (Username.Length == 0 || Password.Length == 0)
                return false;

            return true;
        }
    }
}

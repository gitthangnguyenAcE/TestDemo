using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MyApp_ss3.Models
{
    public class User
    {
        [PrimaryKey]
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string username, string password)
        {
            this.UserName = username;
            this.Password = password;
            this.Name = "Account";
        }

        public bool CheckInformation()
        {
            if (this.UserName == null || this.Password== null) return false;
            else
            {
                if (this.UserName == "admin")
                {
                    if (this.Password == "admin") return true;
                    else return false;
                }
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class UserRegistration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

        public UserRegistration()
        {

        }

        public UserRegistration(string firstname, string lastname, string username, string emailaddress, string password)
        {
            FirstName = firstname;
            LastName = lastname;
            UserName = username;
            EmailAddress = emailaddress;
            Password = password;
        }

    }
}
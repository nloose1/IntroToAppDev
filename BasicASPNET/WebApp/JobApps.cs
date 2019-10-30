using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class JobApps
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FullOrPartTime { get; set; }
        public string Jobs { get; set; }

        public JobApps()
        {

        }
        public JobApps(string fullname, string email, string phone, string time, string jobs)
        {
            FullName = fullname;
            Email = email;
            PhoneNumber = phone;
            FullOrPartTime = time;
            Jobs = jobs;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Travel_Record_App.Model
{
    internal class Users
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long phoneNumber { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime LastUpdatedDate { get; set; } = DateTime.UtcNow;
        public string Email { get; set; }
        public string password { get; set; }
        public string updatePassword { get; set; }
        /*public string updatePassword
        {
            get { return password; }
            set { password = value; }
        }*/



    }
}

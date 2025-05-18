using eventManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem.admin
{
    public class Participant:User
    {
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string mobileNumer { get; set; }
        public string userStatus { get; set; }

        public Participant(string Email, string Role, string Password, string FirstName, string LastName, string MobileNumber, string Status)
        {
            this.email = Email;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.mobileNumer = MobileNumber;
            this.password = Password;
            this.userRole = Role;

   

            this.userStatus = Status;

        }
    }
}

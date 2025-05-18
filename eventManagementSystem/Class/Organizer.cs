using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem.Class
{
    public class Organizer:User
    {
        public string password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string mobileNumer { get; set; }
        public string profileImage { get; set; }
        public string userStatus { get; set; }

        public Organizer(string Email, string Role, string Password,string FirstName, string LastName,string MobileNumber,string ProfileImage,string Status)
        {
            this.email = Email;
            this.password = Password;
            this.userRole = Role;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.mobileNumer = MobileNumber;
            this.profileImage = ProfileImage;
            this.userStatus = Status;

        }
    }
}

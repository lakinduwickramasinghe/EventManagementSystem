using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem.Class
{
    public class Organizer_REQ:User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string mobileNumer { get; set; }
        public string profileImage { get; set; }
        public string moreInfo { get; set; }

        public Organizer_REQ(string Email, string FirstName, string LastName, string MobileNumber, string ProfileImage, string moreInfo, string Role)
        {
            this.email = Email;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.mobileNumer = MobileNumber;
            this.profileImage = ProfileImage;
            this.moreInfo = moreInfo;
            this.userRole = Role;
        }
    }
}

using eventManagementSystem.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem
{
    public class VenueManager:User
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }
        public string mobileNumber { get; set; }
        public string nicNumber { get; set; }
        public string profileImage { get; set; }
        public string password { get; set; }
        public string internalRole { get; set; }
        public string userStatus { get; set; }
        public int userVenueId {  get; set; }

        public VenueManager(string Email, string FirstName,string LastName,string MobileNumber,string NicNumber,string ProfileImage,string Password,string InternalRole,string UserRole,string Status,int VenueId)
        {
            this.email = Email;
            this.firstName = FirstName;
            this.lastName = LastName;
            this.mobileNumber = MobileNumber;
            this.nicNumber = NicNumber;
            this.profileImage = ProfileImage;
            this.password = Password;
            this.internalRole = InternalRole;
            this.userRole = UserRole;
            this.userStatus = Status;
            this.userVenueId = VenueId;
        }
    }
}

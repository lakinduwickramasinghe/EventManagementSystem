using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem.Class
{
    public class Admin:User
    {
        public string userStatus {  get; set; }
        public string password { get; set; }
        public Admin(string Email,string Role, string Password, string userStatus)
        {
            this.email = Email;
            this.password = Password;
            this.userRole = Role;
            this.userStatus = userStatus;
        }
    }
}

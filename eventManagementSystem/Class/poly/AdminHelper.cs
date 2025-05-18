using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem.Class
{
    public class AdminHelper
    {
        private string connectionString;

        public AdminHelper()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

    }
}

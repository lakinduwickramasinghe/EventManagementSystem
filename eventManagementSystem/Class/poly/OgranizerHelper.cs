using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventManagementSystem.Class
{
    public class OgranizerHelper
    {
        private string connectionString;

        public OgranizerHelper()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }
    }
}

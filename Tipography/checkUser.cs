using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipography
{
    public class checkUser
    {
        public string Login { get; set; }

        public sbyte IsAdmin { get; }

        public string Status;
        public string Check()
        {
            if (IsAdmin == 1)
            {
                return Status = "Admin";
            }
            else if (IsAdmin == 2)
            {
                return Status = "Booker";
            }
            else
            {
                return Status = "User";
            }
        }
        
        public checkUser(string login, sbyte isAdmin)
        {
            Login = login.Trim();
            IsAdmin = isAdmin;
            Check();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    class User : IUser
    {
        public  DateTime LastSeen { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string GetFullInfo()
        {
            return Name + " " + Email + " " + Password + " " + LastSeen.ToLongTimeString();
        }

        
    }
}

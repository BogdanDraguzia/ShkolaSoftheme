using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    interface IUser
    {
        string Name { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        DateTime LastSeen { get; set; }
        string GetFullInfo();
    }
}

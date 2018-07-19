using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HW_12
{
    class AuthentificatorByEmail:IAuthentificate
    {
        public void AuthentificateUser(IUser user)
        {
            var index = Database.GetIndexOf(user);
            if (index!=null)
            {
                Console.WriteLine(
                Database.GetUser(Int32.Parse(index.ToString()))
                    .GetFullInfo());
            }
            else
            {
                Database.Add(user);
                Console.WriteLine(
                Database.GetLast().GetFullInfo());
            }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    static class Database
    {
        private static IUser[] Users;

        public static void Add(IUser user)
        {
            if (Users==null)
            {
                Users = new IUser[1];
                user.LastSeen = DateTime.Now;
                Users[0] = user;
            }
            else
            {
                var tmpArr = Users;
                Users = new IUser[tmpArr.Length + 1];
                tmpArr.CopyTo(Users,0);
                user.LastSeen = DateTime.Now;
                Users[Users.Length - 1] = user;
            }

            Console.WriteLine("New user added!");
        }
        

        public static bool Contains(IUser user)
        {
            if (Users!=null)
            {


                foreach (var tmpUser in Users)
                {
                    if (((tmpUser.Name == user.Name && tmpUser.Name!=null)
                         || tmpUser.Email == user.Email && tmpUser.Email!=null) && tmpUser.Password == user.Password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static IUser GetUser(int index)
        {
            return Users[index];
        }

        public static IUser GetLast()
        {
            var tmp = Users[Users.Length - 1];
            return new User() {Email = tmp.Email, Name = tmp.Name, Password = tmp.Password, LastSeen = tmp.LastSeen};
        }

         public static int? GetIndexOf(IUser user)
        {
            if (Database.Contains(user))
            {
                for (int i = 0; i < Users.Length; i++)
                {
                    if ((user.Name == Users[i].Name||user.Email==Users[i].Email)&&user.Password==Users[i].Password)
                    {
                        return i;
                    }
                }
            }

            return null;
        }
    }
}

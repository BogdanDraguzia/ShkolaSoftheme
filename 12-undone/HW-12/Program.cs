using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write your name or email: ");
                string nameOrEmail = Console.ReadLine();
                if (nameOrEmail.ToLower() == "exit") break;

                Console.WriteLine("Password:");
                
                string password = Console.ReadLine();
                if ( password.ToLower()=="exit") break;
           
                if (nameOrEmail.Contains("@"))
                {
                    AuthentificatorByEmail authentificatorByEmail = new AuthentificatorByEmail();
                    authentificatorByEmail.AuthentificateUser(new User
                    {
                        Email = nameOrEmail,
                        Name = null,
                        Password = password
                    });
                }
                else
                {
                    AuthentificatorByEmail authentificatorByEmail = new AuthentificatorByEmail();
                    authentificatorByEmail.AuthentificateUser(new User
                    {
                        Email = null,
                        Name = nameOrEmail,
                        Password = password
                    });
                }

            }
            
        }
        
    }
    
}

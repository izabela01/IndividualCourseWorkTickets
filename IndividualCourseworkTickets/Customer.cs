using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualCourseworkTickets
{
    internal class Customer : User
    {
        String address;

        public Customer(): base()
        {

        }

        public Customer(string user, string hashedpass, string address) : base(user, hashedpass)
        {
            this.address = address;
        }

        public  Customer GetLogin()
        {
            string user;
            string pass;
            string address; 

            do
            {
                Console.WriteLine("Enter your username ... ");
                user = Console.ReadLine();

                if(user.Length < 5)
                {
                    Console.WriteLine("Username must be at least 5 characters!!");
                }

            }
            while (user.Length < 5);

       
            Console.WriteLine("Enter your password!");
            pass = Console.ReadLine();

           Customer newUser = new Customer(user, pass, "");
            
            Console.WriteLine("Congrats .. " + newUser.userName);
            return newUser; 
     
        }

        public void updateAddress(string address)
        {
            this.address = address; 
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualCourseworkTickets
{
    internal class User 
    {
        private string userID;
        public string userName;
        private string hashedPassword;

        public User()
        {
            
        }
        public User(string UserName, string HashedPassword)
        {
            userID = "5";
            this.userName = UserName;
            this.hashedPassword = HashedPassword;
        }
    }
}

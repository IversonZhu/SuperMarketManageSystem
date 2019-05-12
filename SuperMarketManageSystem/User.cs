using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketManageSystem
{
    public class User
    {
        private int userID;
        private string username;
        private string password;

        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }
    }
}

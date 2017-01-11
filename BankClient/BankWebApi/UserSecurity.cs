using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccessLayer;

namespace BankWebApi
{
    public class UserSecurity
    {
        public static bool Login(string username, string password)
        {
            using (bankEntities bankentity = new bankEntities())
            {
                return bankentity.LogIns.Any(user => user.LoginID.Equals(username) && user.Password == password);
            }

        }
    }
}
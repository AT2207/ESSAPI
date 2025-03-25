using ESS.DataAccess.Interfaces;
using ESS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.DataAccess.Services
{
    public class AuthService : IAuthService
    {
        public UserResponse? ValidateUser(string username, string password)
        {
            // Replace this with DB logic
            if (username == "aalocked" && password == "1234")
            {
                return new UserResponse
                {
                    Username = "aalocked",
                    FirstName = "Aalok",
                    LastName = "Dubey",
                    Email = "adubey@balajeegroup.com",
                    ContactNo = "1234567890"
                };
            }

            return null;
        }
    }

}






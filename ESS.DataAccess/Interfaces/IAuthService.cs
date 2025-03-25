using ESS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.DataAccess.Interfaces
{
    public interface IAuthService
    {
        UserResponse? ValidateUser(string username, string password);
    }
}

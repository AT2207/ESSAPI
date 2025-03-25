using ESS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.DataAccess.Facade
{
    public interface IAuthFacade
    {
        UserResponse? Authenticate(string username, string password);

    }
}

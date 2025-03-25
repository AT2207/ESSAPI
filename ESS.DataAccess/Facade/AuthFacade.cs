using ESS.DataAccess.Interfaces;
using ESS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESS.DataAccess.Facade
{
    public class AuthFacade : IAuthFacade
    {
        private readonly IAuthService _authService;

        public AuthFacade(IAuthService authService)
        {
            _authService = authService;
        }

        public UserResponse? Authenticate(string username, string password)
        {
            return _authService.ValidateUser(username, password);
        }
    }
}

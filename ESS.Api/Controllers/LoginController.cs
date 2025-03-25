using ESS.DataAccess.Facade;
using ESS.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace ESS.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IAuthFacade _authFacade;

        public LoginController(IAuthFacade authFacade)
        {
            _authFacade = authFacade;
        }

        [HttpPost]
        public IActionResult Index([FromBody] User userRequest)
        {
            var user = _authFacade.Authenticate(userRequest.Username, userRequest.Password);

            if (user == null)
                return Unauthorized();

            return Ok(user);
        }
    }
}

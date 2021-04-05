using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ReactCoreCRUD.Entities;
using ReactCoreCRUD.Interfaces;
using ReactCoreCRUD.Utils;
using System.Threading.Tasks;

namespace ReactCoreCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
        public LoginController(IConfiguration config)
        {
            this._config = config;
        }

        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 401)]
        [HttpGet("authenticate/{email}")]
        public string Login(string email)
        {
            var jwt = new JwtService(_config);
            var token = jwt.GenerateSecurityToken(email);
            return token;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp()
        {
            return Ok();
        }
    }
}

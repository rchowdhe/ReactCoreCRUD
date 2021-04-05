using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ReactCoreCRUD.Entities;
using ReactCoreCRUD.Interfaces;
using ReactCoreCRUD.Utils;
using System.Threading.Tasks;

namespace ReactCoreCRUD.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IWebHostEnvironment environment;
        public UserController(IWebHostEnvironment environment, IUnitOfWork unitOfWork)
        {
            this.environment = environment;
            this.unitOfWork = unitOfWork;
        }

        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(typeof(string), 400)]
        [ProducesResponseType(typeof(string), 401)]
        [HttpGet("getallusers")]
        [Authorize]
        public async Task<IActionResult> GetAll()
        {
            var data = await unitOfWork.UserDetails.GetAllAsync();
            return Ok(data);
        }

        [HttpGet("getuser/{id}")]
        [Authorize]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await unitOfWork.UserDetails.GetByIdAsync(id);
            if (data == null) return Ok();
            return Ok(data);
        }

        [HttpPost("adduser")]
        public async Task<IActionResult> Add([FromForm] UserDetails parameter)
        {
            ObjectMapper mapper = new ObjectMapper(environment.ContentRootPath);
            UserDetails user = mapper.ConvertToObject(parameter);
            await unitOfWork.UserDetails.AddAsync(user);
            return Ok(user);
        }

        [HttpDelete("removeuser/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await unitOfWork.UserDetails.DeleteAsync(id);
            return Ok();
        }

        [HttpPut("updateuser/{id}")]
        public async Task<IActionResult> Update([FromForm] UserDetails parameter, int id)
        {
            ObjectMapper mapper = new ObjectMapper(environment.ContentRootPath);
            UserDetails user = mapper.ConvertToObject(parameter);

            await unitOfWork.UserDetails.UpdateAsync(user, id);
            return Ok(user);
        }
    }
}

using BookLibrary.Core.Models;
using BookLibrary.Database.Entities;
using BookLibrary.Database.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public UserRepository _userRepository;

        [HttpGet]
        public async Task<ActionResult<UserEntity>> GetUsers(/*[FromQuery(Name = "page")] int page, [FromQuery(Name = "pageCount")] int pageCount*/)
        {
            var users = await _userRepository.GetAll(1, 10);

            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateUser([FromBody] Book request)
        {

        }


    }
}

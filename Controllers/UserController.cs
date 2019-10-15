using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApiMultipleDb.Models;
using webApiMultipleDb.Repository;

namespace webApiMultipleDb.Controllers
{
    [Route("api/[controller]")] 
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
        {
            var users = await _userRepository.GetUsers();
            return Ok(users);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> Post([FromBody]User user)
        {            
           await _userRepository.AddUser(user);
           return Ok();
        }
  }
}
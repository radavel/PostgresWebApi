using PostgresWebApi.Models;
using PostgresWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace PostgresWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<User>> GetAllUsers()
        {
            return _service.GetAllUsers();
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            return _service.GetUserById(id);
        }

        [HttpPost("store")]
        public IActionResult CreateUser(User user)
        {
            Console.WriteLine("Store User");
            var userCreated = _service.CreateNewUser(user);

            return CreatedAtAction(nameof(CreateUser), new { Id = userCreated.Id }, userCreated);
        }

        [HttpPut("update")]
        public IActionResult UpdateUser(User user)
        {
            _service.UpdateUser(user);

            return NoContent();
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteUser(int id)
        {
            _service.DeleteUser(id);

            return NoContent();
        }
    }
}
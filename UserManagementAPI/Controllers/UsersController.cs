using Microsoft.AspNetCore.Mvc;
using UserManagementAPI.Models;

namespace UserManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private static readonly List<User> users = new();

        [HttpGet]
        public IActionResult GetUsers() => Ok(users);

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            user.Id = Guid.NewGuid();
            users.Add(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            return user is null ? NotFound() : Ok(user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(Guid id, User updatedUser)
        {
            var index = users.FindIndex(u => u.Id == id);
            if (index == -1) return NotFound();

            updatedUser.Id = id;
            users[index] = updatedUser;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(Guid id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user is null) return NotFound();

            users.Remove(user);
            return NoContent();
        }
    }
}
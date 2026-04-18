using Microsoft.AspNetCore.Mvc;

namespace CredentialCheckExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        // In a real application, you would check against a database or secure store.
        // This is just for demonstration.
        private const string ValidUsername = "admin";
        private const string ValidPassword = "password123"; // Never hardcode passwords in real code!

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (model == null)
            {
                return BadRequest("Invalid request");
            }

            // Check credentials (in a real app, use hashed passwords and a secure comparison)
            if (model.Username == ValidUsername && model.Password == ValidPassword)
            {
                // You would typically generate a token or set a cookie here
                return Ok(new { message = "Login successful" });
            }
            else
            {
                return Unauthorized(new { message = "Invalid username or password" });
            }
        }
    }

    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
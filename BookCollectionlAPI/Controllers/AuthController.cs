using BookCollectionAPI.Dtos;
using BookCollectionAPI.Entities;
using BookCollectionAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookCollectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }
        // POST: api/auth/register
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            var user = await _authService.RegisterAsync(request);
            if (user is null) return BadRequest("Username already exists.");
            return Ok(user);
        }

    }
}

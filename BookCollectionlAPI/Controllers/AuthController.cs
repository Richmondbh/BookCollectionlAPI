using BookCollectionAPI.Dtos;
using BookCollectionAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookCollectionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        // POST: api/auth/register
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
           
        }

    }
}

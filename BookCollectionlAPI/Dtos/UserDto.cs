using System.ComponentModel.DataAnnotations;

namespace BookCollectionAPI.Dtos
{
    public class UserDto
    {
        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        [MinLength(6)]
        public string Password { get; set; } = string.Empty;
    }
}

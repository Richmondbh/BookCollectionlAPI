
namespace BookCollectionAPI.Dtos
{
    public class UserResponseDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Role { get; set; } = "User";

        
    }
}

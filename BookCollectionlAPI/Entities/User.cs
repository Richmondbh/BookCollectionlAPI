using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCollectionAPI.Entities
{
    public class User
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("username")]
        public string Username { get; set; } = string.Empty;

        [Required]
        [Column("password_hash")]
        public string PasswordHash { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Column("role")]
        public string Role { get; set; } = string.Empty;

        [Column("refresh_token")]
        public string? RefreshToken { get; set; }

        [Column("refresh_token_expiry")]
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}

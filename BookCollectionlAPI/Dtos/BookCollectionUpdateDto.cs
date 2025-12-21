using System.ComponentModel.DataAnnotations;

namespace BookCollectionAPI.Dtos
{
    public class BookCollectionUpdateDto
    {
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }


        [Required]
        [MaxLength(100)]
        public string Author { get; set; } = string.Empty;

        [Required]
        [MaxLength(400)]
        public string Description { get; set; }     

        [Required]
        [MaxLength(100)]
        public string Genre { get; set; }

        [Required]
        [Range(1800, 2100)]
        public int PublicationYear { get; set; }
    }
}

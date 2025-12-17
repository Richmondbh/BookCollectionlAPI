using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCollectionAPI.Models
{
    [Table("books")]
    public class Book
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        [Column("title")]
        public string Title { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("author")]
        public string Author { get; set; }

        [Required]
        [MaxLength(400)]
        [Column("description")]
        public string? Description { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("genre")]
        public string Genre { get; set; }

        [Required]
        [Range(1800, 2100)]
        [Column("publication_year")]
        public int PublicationYear { get; set; }


    }
}

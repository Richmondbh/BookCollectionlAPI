using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCollectionAPI.Dtos
{
    public class BookCollectionReadDto
    {
         
            public int Id { get; set; }

            
            public string Title { get; set; }

            
            public string Author { get; set; }

            public string? Description { get; set; }

   
            public string Genre { get; set; }

          
            public int PublicationYear { get; set; }

        
    }
}

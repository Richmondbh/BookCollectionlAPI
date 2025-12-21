using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCollectionAPI.Dtos
{
    public class BookCollectionReadDto
    {
         
            public int Id { get; set; }

            
            public string Title { get; set; } = string.Empty;

            
            public string Author { get; set; } = string.Empty;

            public string Description { get; set; } = string.Empty;

   
            public string Genre { get; set; } = string.Empty;

          
            public int PublicationYear { get; set; }    

        
    }
}

using BookCollectionAPI.Models;

namespace BookCollectionAPI.Data
{
    public class MockBookRepo : IBookCollectionRepo
    {
        public Book GetBookById(int id)
        {
            return new Book
            {
                Id = 0,
                Author = "Richmond",
                Description = "How to create Api",
                Genre = "Software Development",
                Title = "Api Pro",
                PublicationYear = 2000
            };
        }

        public IEnumerable<Book> GetBooks()
        {
            var books = new List<Book>
            {
                new Book
            {
                Id = 0,
                Author = "Richmond",
                Description = "How to create an Api",
                Genre = "Software Development",
                Title = "Api Pro",
                PublicationYear = 2000
            },
                new Book
            {
                Id = 2,
                Author = "Boakye",
                Description = "How to cook",
                Genre = "Catering",
                Title = "Cooking Pro",
                PublicationYear = 2000
            },
                new Book
            {
                Id = 3,
                Author = "Hope",
                Description = "How to dance",
                Genre = "Dance",
                Title = "Dancing Pro",
                PublicationYear = 2000
            }
            };

            return books;
        }
    }
}

using BookCollectionAPI.Models;

namespace BookCollectionAPI.Data
{
    public class MockBookRepo : IBookCollectionRepo
    {
        public void CreateBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookByIdAsync(int id)
        {
            var book =new Book
            {
                Id = 0,
                Author = "Richmond",
                Description = "How to create Api",
                Genre = "Software Development",
                Title = "Api Pro",
                PublicationYear = 2000
            };

            return Task.FromResult<Book?>(book);
        }


        public Task<IEnumerable<Book>> GetBooksAsync()
        {
            var books = new List<Book>
            {
                new Book
            {
                Id = 1,
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

            return Task.FromResult<IEnumerable<Book>>(books);
        }


        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}

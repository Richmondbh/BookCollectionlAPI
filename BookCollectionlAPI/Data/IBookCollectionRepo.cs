using BookCollectionAPI.Models;

namespace BookCollectionAPI.Data
{
    public interface IBookCollectionRepo
    {
      IEnumerable<Book> GetBooks();
      Book GetBookById(int id);
    }
}

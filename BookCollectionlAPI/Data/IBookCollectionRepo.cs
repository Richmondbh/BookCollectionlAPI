using BookCollectionAPI.Models;

namespace BookCollectionAPI.Data
{
    public interface IBookCollectionRepo
    {

      bool SaveChanges ();
      IEnumerable<Book> GetBooks();
      Book GetBookById(int id);
      void CreateBook(Book book);
    }
}

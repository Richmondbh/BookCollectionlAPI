using BookCollectionAPI.Models;

namespace BookCollectionAPI.Data
{
    public interface IBookCollectionRepo
    {

      bool SaveChanges ();
      IEnumerable<Book> GetBooks();
      Book GetBookById(int id);
      void CreateBook(Book book);
        void UpdateBook(Book book); 
        void DeleteBook(Book book);
    }
}

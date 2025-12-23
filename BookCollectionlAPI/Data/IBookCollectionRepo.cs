using BookCollectionAPI.Models;

namespace BookCollectionAPI.Data
{
    public interface IBookCollectionRepo
    {

      Task <bool> SaveChangesAsync ();
      Task<IEnumerable<Book>> GetBooksAsync();
      Task<Book?> GetBookByIdAsync(int id);
      void CreateBook(Book book);
        void UpdateBook(Book book); 
        void DeleteBook(Book book);
    }
}

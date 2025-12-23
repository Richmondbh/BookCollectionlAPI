using BookCollectionAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCollectionAPI.Data
{
    public class SqlBookCollectionsRepo : IBookCollectionRepo
    {
        private readonly BookCollectionContext _context;

        public SqlBookCollectionsRepo(BookCollectionContext context)
        {
            _context = context;
        }

        public void CreateBook(Book book)
        {
          if (book == null) { throw new ArgumentNullException (nameof(book)); }

          _context.Books.Add(book);
        }

        public void DeleteBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException (nameof(book));

            }
            _context.Books.Remove(book);
        }

        public async Task <Book?> GetBookByIdAsync(int id)
        {
            return await _context.Books.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
           return await  _context.Books.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync ()
        {
            var result = await _context.SaveChangesAsync();
            return result > 0;
            //return await (_context.SaveChangesAsync()) >0;

        }

        public void UpdateBook(Book book)
        {
           
        }
    }
}

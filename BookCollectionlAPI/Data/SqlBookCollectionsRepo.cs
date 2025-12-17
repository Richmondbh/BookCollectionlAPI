using BookCollectionAPI.Models;

namespace BookCollectionAPI.Data
{
    public class SqlBookCollectionsRepo : IBookCollectionRepo
    {
        private readonly BookCollectionContext _context;

        public SqlBookCollectionsRepo(BookCollectionContext context)
        {
            _context = context;
        }
        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
           return _context.Books.ToList();
        }
    }
}

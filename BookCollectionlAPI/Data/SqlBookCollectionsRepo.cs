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

        public void CreateBook(Book book)
        {
          if (book == null) { throw new ArgumentNullException (nameof(book)); }

          _context.Books.Add(book);
        }

        public Book GetBookById(int id)
        {
            return _context.Books.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
           return _context.Books.ToList();
        }

        public bool SaveChanges()
        {
          return ( _context.SaveChanges() >0);
        }

        public void UpdateBook(Book book)
        {
           
        }
    }
}

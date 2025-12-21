using BookCollectionAPI.Entities;
using BookCollectionAPI.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BookCollectionAPI.Data
{
    public class BookCollectionContext : DbContext
    {
        public BookCollectionContext(DbContextOptions<BookCollectionContext> opt) : base(opt)
        {
        
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

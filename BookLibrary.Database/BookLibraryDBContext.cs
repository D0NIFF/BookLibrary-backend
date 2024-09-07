using BookLibrary.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Domain
{
    public class BookLibraryDBContext : DbContext
    {
        public BookLibraryDBContext(DbContextOptions<BookLibraryDBContext> options)
            : base(options)
        {

        }

        public DbSet<BookCategoryEntity> BookCategories { get; set; }
        public DbSet<BookEntity> Books { get; set; }
    }
}

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
        public DbSet<BookAuthorEntity> BookAuthors { get; set; }
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<BookOnAuthor> BooksOnAuthors { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<FavoriteGroupEntity> FavoriteGroups { get; set; }
        public DbSet<FavoriteEntity> Favorites { get; set; }
    }
}

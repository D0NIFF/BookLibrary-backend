using BookLibrary.Database.Entities;
using BookLibrary.Database.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Database
{
    public class BookLibraryDBContext : DbContext
    {
        public BookLibraryDBContext(DbContextOptions<BookLibraryDBContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<BookCategoryEntity> BookCategories { get; set; }
        public DbSet<BookAuthorEntity> BookAuthors { get; set; }
        public DbSet<BookEntity> Books { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<FavoriteGroupEntity> FavoriteGroups { get; set; }
        public DbSet<FavoriteEntity> Favorites { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new BookAuthorConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new FavoriteGroupConfiguration());
            modelBuilder.ApplyConfiguration(new FavoriteConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}

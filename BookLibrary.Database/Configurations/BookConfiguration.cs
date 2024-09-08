using BookLibrary.Core.Models;
using BookLibrary.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookLibrary.Database.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<BookEntity>
    {
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Name)
                .HasMaxLength(Book.MAX_NAME_LENGTH)
                .IsRequired();

            builder.Property(b => b.Description)
                .IsRequired();

            builder.Property(b => b.Img)
                .IsRequired();

            builder.Property(b => b.Caption)
                .IsRequired();

            builder
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId);

            builder
                .HasMany(b => b.Authors)
                .WithMany(a => a.Books);

            builder
                .HasMany(b => b.Favorites)
                .WithOne(f => f.Book)
                .HasForeignKey(f => f.BookId);
        }
    }
}

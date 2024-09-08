using BookLibrary.Core.Models;
using BookLibrary.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookLibrary.Database.Configurations
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthorEntity>
    {
        public void Configure(EntityTypeBuilder<BookAuthorEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.FirstName)
                .HasMaxLength(BookCategory.MAX_NAME_LENGTH)
                .IsRequired();

            builder.Property(b => b.LastName)
                .HasMaxLength(BookCategory.MAX_NAME_LENGTH)
                .IsRequired();

            builder
                .HasMany(x => x.Books)
                .WithMany(b => b.Authors);
        }
    }
}

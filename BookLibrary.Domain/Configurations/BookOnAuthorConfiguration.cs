using BookLibrary.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookLibrary.Database.Configurations
{
    public class BookOnAuthorConfiguration : IEntityTypeConfiguration<BookOnAuthorEntity>
    {
        public void Configure(EntityTypeBuilder<BookOnAuthorEntity> builder)
        {
            builder.Property(b => b.AuthorId)
                .IsRequired();

            builder.Property(b => b.BookId)
                .IsRequired();
        }
    }
}

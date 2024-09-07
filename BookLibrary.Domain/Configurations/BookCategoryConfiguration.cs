using BookLibrary.Core.Models;
using BookLibrary.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookLibrary.Database.Configurations
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategoryEntity>
    {
        public void Configure(EntityTypeBuilder<BookCategoryEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Name)
                .HasMaxLength(BookCategory.MAX_NAME_LENGTH)
                .IsRequired();
        }
    }
}

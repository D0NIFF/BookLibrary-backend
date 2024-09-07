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
                .HasOne(c => c.Category)
                .WithOne(b => b.Category)
                .HasForeignKey(c => c.Category.Id)
            builder.Property(b => b.CategoryId)
                .IsRequired();
        }
    }

    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(u => u.Nickname)
                .HasMaxLength(User.MAX_NAME_LENGTH)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasMaxLength(BookCategory.MAX_NAME_LENGTH)
                .IsRequired();
        }
    }
}

using BookLibrary.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookLibrary.Database.Configurations
{
    public class FavoriteConfiguration : IEntityTypeConfiguration<FavoriteEntity>
    {
        public void Configure(EntityTypeBuilder<FavoriteEntity> builder)
        {
            builder
                .HasOne(f => f.User)
                .WithMany(u => u.Favorites)
                .HasForeignKey(f => f.UserId);

            builder
                .HasOne(f => f.Group)
                .WithMany(g => g.Favorites)
                .HasForeignKey(f => f.GroupId);

            builder
                .HasOne(f => f.Book)
                .WithMany(b => b.Favorites)
                .HasForeignKey(f => f.BookId);
        }
    }
}

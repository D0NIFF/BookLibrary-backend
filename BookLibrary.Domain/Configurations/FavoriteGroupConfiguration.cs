using BookLibrary.Core.Models;
using BookLibrary.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookLibrary.Database.Configurations
{
    public class FavoriteGroupConfiguration : IEntityTypeConfiguration<FavoriteGroupEntity>
    {
        public void Configure(EntityTypeBuilder<FavoriteGroupEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.Name)
                .HasMaxLength(FavoriteGroup.MAX_NAME_LENGTH)
                .IsRequired();

            builder
                .HasOne(g => g.User)
                .WithMany(u => u.FavoriteGroups)
                .HasForeignKey(g => g.UserId);

            builder
                .HasMany(g => g.Favorites)
                .WithOne(f => f.Group)
                .HasForeignKey(f => f.GroupId);
        }
    }
}

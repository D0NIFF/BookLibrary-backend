namespace BookLibrary.Database.Entities
{
    public class FavoriteGroupEntity
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public Guid UserId { get; set; }

        public UserEntity? User { get; set; }

        public ICollection<FavoriteEntity>? Favorites { get; }

        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
    }
}

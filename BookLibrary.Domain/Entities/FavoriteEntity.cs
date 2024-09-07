namespace BookLibrary.Database.Entities
{
    public class FavoriteEntity
    {
        public Guid UserId { get; set; }

        public UserEntity? User { get; set; }

        public Guid GroupId { get; set; }

        public FavoriteGroupEntity? Group { get; set; }

        public Guid BookId { get; set; }

        public BookEntity? Book { get; set; }

        public DateTime? CreatedAt { get; set; } = DateTime.Now;
    }
}

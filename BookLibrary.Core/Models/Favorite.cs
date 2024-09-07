namespace BookLibrary.Core.Models
{
    public class Favorite
    {
        private Favorite(Guid userId, Guid groupId, Guid bookId)
        {
            UserId = userId;
            GroupId = groupId;
            BookId = bookId;
            CreatedAt = DateTime.Now;
        }

        public Guid UserId { get; }

        public User? User { get; }

        public Guid GroupId { get; }

        public FavoriteGroup? Group { get; }

        public Guid BookId { get; }

        public Book? Book { get; }

        public DateTime? CreatedAt { get; } = DateTime.Now;

        public static (Favorite Favorite, string Error) Create(Guid userId, Guid groupId, Guid bookId)
        {
            var error = string.Empty;

            if (userId == null) error = "User cannot be empty!";
            if (bookId == null) error = "Book cannot be empty!";

            var favorite = new Favorite(userId, groupId, bookId);
            return (favorite, error);
        }
    }
}

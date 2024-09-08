namespace BookLibrary.Core.Models
{
    public class Favorite
    {
        private Favorite(int id, Guid userId, Guid groupId, Guid bookId)
        {
            Id = id;
            UserId = userId;
            GroupId = groupId;
            BookId = bookId;
            CreatedAt = DateTime.Now;
        }

        public int Id { get; }

        public Guid UserId { get; }

        public User? User { get; }

        public Guid GroupId { get; }

        public FavoriteGroup? Group { get; }

        public Guid BookId { get; }

        public Book? Book { get; }

        public DateTime? CreatedAt { get; } = DateTime.Now;

        public static (Favorite Favorite, string Error) Create(int id, Guid userId, Guid groupId, Guid bookId)
        {
            var error = string.Empty;

            if (userId == null) error = "User cannot be empty!";
            if (bookId == null) error = "Book cannot be empty!";

            var favorite = new Favorite(id, userId, groupId, bookId);
            return (favorite, error);
        }
    }
}

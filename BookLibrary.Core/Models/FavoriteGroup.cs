using System.Xml.Linq;

namespace BookLibrary.Core.Models
{
    public class FavoriteGroup
    {
        public const int MAX_NAME_LENGTH = 255;

        private FavoriteGroup(Guid id, string name, Guid userId)
        {
            Id = id;
            Name = name;
            UserId = userId;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public Guid Id { get; }

        public string? Name { get; }

        public Guid UserId { get; }

        public User? User { get; }

        public ICollection<Favorite>? Favorites { get; }

        public DateTime? CreatedAt { get; } = DateTime.Now;
        public DateTime? UpdatedAt { get; } = DateTime.Now;

        public static (FavoriteGroup FavoriteGroup, string Error) Create(Guid id, string name, Guid userId)
        {
            var error = string.Empty;

            if (string.IsNullOrWhiteSpace(name) || name.Length > MAX_NAME_LENGTH) error = "Group name cannot be empty or longer 255 symbols!";
            if (userId == null) error = "User cannot be empty!";

            var favoriteGroup = new FavoriteGroup(id, name, userId);
            return (favoriteGroup, error);
        }
    }
}

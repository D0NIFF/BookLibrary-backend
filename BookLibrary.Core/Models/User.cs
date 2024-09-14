namespace BookLibrary.Core.Models
{
    public class User
    {
        public const int MAX_NAME_LENGTH = 255;

        private User(Guid id, string nickname, string email, string passwordHash)
        {
            Id = id;
            Nickname = nickname;
            Email = email;
            PasswordHash = passwordHash;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public Guid Id { get; }

        public string? Nickname { get; }

        public string? Email { get; }

        public string? PasswordHash { get; }

        public ICollection<FavoriteGroup> FavoriteGroups { get; }
        public ICollection<Favorite> Favorites { get; }

        public DateTime? CreatedAt { get; } = DateTime.Now;
        public DateTime? UpdatedAt { get; } = DateTime.Now;
        public DateTime? DeletedAt { get; }

        public static (User user, string Error) Create(Guid id, string? nickname, string? email, string passwordHash)
        {
            var error = string.Empty;

            if (string.IsNullOrWhiteSpace(nickname) || nickname.Length > MAX_NAME_LENGTH) error = "Nickname cannot be empty or longer 255 symbols!";
            if (string.IsNullOrWhiteSpace(email) || email.Length > MAX_NAME_LENGTH) error = "Email cannot be empty or longer 255 symbols!";

            var user = new User(id, nickname, email, passwordHash);
            return (user, error);
        }
    }
}

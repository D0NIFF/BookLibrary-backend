namespace BookLibrary.Database.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }

        public string? Nickname { get; set; }

        public string? Email { get; set; }

        public string? PasswordHash { get; set; }

        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;
        public DateTime? DeletedAt { get; set; }
    }
}

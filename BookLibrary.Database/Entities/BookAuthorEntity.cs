namespace BookLibrary.Database.Entities
{
    public class BookAuthorEntity
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

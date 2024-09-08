using BookLibrary.Core.Models;

namespace BookLibrary.Database.Entities
{
    public class BookAuthorEntity
    {
        public Guid Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public ICollection<BookEntity>? Books { get; }

        public DateTime CreatedAt { get; set; }
    }
}

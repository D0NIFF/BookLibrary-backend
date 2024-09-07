namespace BookLibrary.Database.Entities
{
    public class BookEntity
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; } = String.Empty;

        public string? Img { get; set; } = String.Empty;

        public string? Caption { get; set; }

        public Guid? CategoryId { get; set; }

        public BookCategoryEntity Category { get; set; }

        public DateOnly ReleaseDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public DateTime DeletedAt { get; set; }
    }
}

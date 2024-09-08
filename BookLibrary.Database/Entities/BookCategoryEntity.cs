namespace BookLibrary.Database.Entities
{
    public class BookCategoryEntity
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public ICollection<BookEntity>? Books { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

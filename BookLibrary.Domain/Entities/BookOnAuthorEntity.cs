namespace BookLibrary.Database.Entities
{
    public class BookOnAuthorEntity
    {
        public Guid BookId { get; set; }

        public BookEntity? Book { get; set; }

        public Guid AuthorId { get; set; }

        public BookAuthorEntity? Author { get; set; }
    }
}

namespace BookLibrary.Database.Entities
{
    public class BookOnAuthor
    {
        public Guid BookId { get; set; }

        public BookEntity? Book { get; set; }

        public Guid AuthorId { get; set; }

        public BookAuthorEntity? Author { get; set; }
    }
}

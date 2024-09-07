namespace BookLibrary.Core.Models
{
    public class Book
    {

        public const int MAX_NAME_LENGTH = 255;

        private Book(Guid id, string name, string description, string img, string caption, Guid categoryId, DateOnly releaseDate)
        {
            Id = id;
            Name = name;
            Description = description;
            Img = img;
            Caption = caption;
            CategoryId = categoryId;
            ReleaseDate = releaseDate;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public Guid Id { get; }

        public string? Name { get; }

        public string? Description { get; } = String.Empty;

        public string? Img { get; } = String.Empty;

        public string? Caption { get; }

        public Guid? CategoryId { get; }

        public BookCategory? Category { get; }

        public DateOnly ReleaseDate { get; }

        public DateTime CreatedAt { get; } = DateTime.Now;

        public DateTime UpdatedAt { get; } = DateTime.Now;

        public DateTime DeletedAt { get; }

        public static (Book Book, string Error) Create(Guid id, string? name, string? description, string? img, string? caption, Guid categoryId, DateOnly releaseDate)
        {
            var error = string.Empty;

            if (string.IsNullOrWhiteSpace(name) || name.Length > MAX_NAME_LENGTH) error = "Book title cannot be empty or longer 255 symbols!";
            if (string.IsNullOrWhiteSpace(description)) error = "Description cannot be empty!";
            if (string.IsNullOrWhiteSpace(img)) error = "Book picture cannot be empty!";
            if (string.IsNullOrWhiteSpace(caption)) error = "PDF file cannot be empty!";
            if (categoryId == null) error = "Category cannot be empty!";

            var book = new Book(id, name, description, img, caption, categoryId, releaseDate);
            return (book, error);
        }
    }
}

namespace BookLibrary.Core.Models
{
    public class BookCategory
    {
        public const int MAX_NAME_LENGTH = 255;

        private BookCategory(Guid id,  string name)
        {
            Id = id;
            Name = name;
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; }

        public string? Name { get; }

        public DateTime CreatedAt { get; }

        public static (BookCategory BookCategory, string Error) Create(Guid id, string? name)
        {
            var error = string.Empty;

            if (string.IsNullOrWhiteSpace(name)) error = "Name cannot be empty!";
            if (name.Length > MAX_NAME_LENGTH) error = "Name cannot be longer 255 symbols!";

            var bookCategory = new BookCategory(id, name);
            return (bookCategory, error);
        }
    }
}

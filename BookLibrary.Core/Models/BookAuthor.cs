using System.Xml.Linq;

namespace BookLibrary.Core.Models
{
    public class BookAuthor
    {

        public const int MAX_NAME_LENGTH = 255;

        private BookAuthor(Guid id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CreatedAt = DateTime.Now;
        }

        public Guid Id { get; }

        public string? FirstName { get; }

        public string? LastName { get; }

        public ICollection<Book> Books { get; }

        public DateTime CreatedAt { get; }

        public static (BookAuthor BookAuthor, string Error) Create(Guid id, string? firstName, string? lastName)
        {
            var error = string.Empty;

            if (string.IsNullOrWhiteSpace(firstName) || firstName.Length > MAX_NAME_LENGTH) error = "First name cannot be empty or longer 255 symbols!";
            if (string.IsNullOrWhiteSpace(lastName) || lastName.Length > MAX_NAME_LENGTH) error = "First name cannot be empty or longer 255 symbols!";

            var bookAuthor = new BookAuthor(id, firstName, lastName);
            return (bookAuthor, error);
        }
    }
}

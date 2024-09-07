﻿namespace BookLibrary.Database.Entities
{
    public class BookCategoryEntity
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}

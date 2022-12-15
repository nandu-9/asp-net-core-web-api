namespace book_store.Data.Models
{
    // Note: Each model must be thought of as a entry in a row of the respective plural table.
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public int?  Rating { get; set; }
        public DateTime? DateRead { get; set; }
        public DateTime DateAdded { get; set; }
        public string CoverURL { get; set; }
        public string Genre { get; set; }


        // Navigation Properties
        public int? PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<Book_Author> Book_Authors { get; set; } // Note: The naming implies 1-to-many relation
    }
}

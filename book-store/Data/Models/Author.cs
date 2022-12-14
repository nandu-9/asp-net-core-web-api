namespace book_store.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        // Navigation Properties
        public List<Book_Author> Book_Authors { get; set; } // Note: The naming implies 1-to-many relation

    }
}

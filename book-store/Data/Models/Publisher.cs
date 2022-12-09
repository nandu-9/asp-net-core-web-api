namespace book_store.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation props
        public List<Book> Books { get; set; }
    }
}

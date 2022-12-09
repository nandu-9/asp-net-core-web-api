namespace book_store.Data.Models.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string CoverURL { get; set; }
        public string Genre { get; set; }
        public bool IsRead { get; set; }
        public int? Rating { get; set; }
        public DateTime? DateRead { get; set; }

        public int PublisherId { get; set; }
        public List<int> AuthorIds { get; set; }
    }
}

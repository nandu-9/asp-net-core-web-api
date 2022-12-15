namespace book_store.Data.Models.ViewModels
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverURL { get; set; }
        public string Genre { get; set; }
        public bool IsRead { get; set; }
        public int? Rating { get; set; }
        public DateTime? DateRead { get; set; }


        // Properties that represent new data-base schema
        public int PublisherId { get; set; } // A book can have only one publisher
        public List<int> AuthorIds { get; set; } // A book can have more than one Authors
    }

    public class BooksWithAuthorsVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverURL { get; set; }
        public string Genre { get; set; }
        public bool IsRead { get; set; }
        public int? Rating { get; set; }
        public DateTime? DateRead { get; set; }


        // Properties that represent new data-base schema
        public string PublisherName { get; set; } // A book can have only one publisher
        public List<string> AuthorNames { get; set; } // A book can have more than one Authors
    }
}

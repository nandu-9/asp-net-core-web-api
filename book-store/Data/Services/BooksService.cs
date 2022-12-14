using book_store.Data.Models;
using book_store.Data.Models.ViewModels;
using System.Threading;

namespace book_store.Data.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        public void AddBookWithAuthors(BookVM book)
        {
            var _book = new Book() {
                Title=book.Title,
                Description=book.Description,
                IsRead=book.IsRead,
                DateRead=book.IsRead ? book.DateRead : null,
                Rating= book.IsRead ? book.Rating : null,
                Genre=book.Genre,
                CoverURL=book.CoverURL,
                DateAdded=DateTime.Now,
                PublisherId=book.PublisherId,

            };

            _context.Books.Add(_book);
            _context.SaveChanges();

            foreach (var id in book.AuthorIds)
            {
                var _book_author = new Book_Author()
                {
                    BookId=id,
                    AuthorId=id,
                };
                _context.Books_Authors.Add(_book_author);
                _context.SaveChanges();
            }
        }

        public List<Book> GetAllBooks() => _context.Books.ToList();
        public Book GetBookById(int bookId) => _context.Books.FirstOrDefault(n => n.Id == bookId);



    }
}

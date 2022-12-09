using book_store.Data.Models.ViewModels;
using book_store.Data.Models;

namespace book_store.Data.Services
{
    public class AuthorService
    {
        private AppDbContext _context;
        public AuthorService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author()
            {
                FullName= author.FullName,  

            };

            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}

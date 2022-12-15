using book_store.Data.Models;
using System.Threading;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace book_store.Data
{
    public class AppDbInitializer
    {
        // Used for populating the initial values in the database.
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            { 
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (context == null) return;
                if (!context.Books.Any())
                { 
                    context.Books.AddRange(new Book() { 
                        Title="First Book",
                        Description="First Book Description",
                        IsRead=true,
                        Rating=5,
                        DateRead= DateTime.Now.AddDays(-10),
                        DateAdded=DateTime.Now,
                        CoverURL="https...",
                        Genre="Sci-fi"
                    },
                    new Book() {
                        Title = "Second Book",
                        Description = "Second Book Description",
                        IsRead = false,
                        DateAdded = DateTime.Now,
                        CoverURL = "https...",
                        Genre = "Adventure"
                    });

                    context.SaveChanges();
                }
            }
        
        }
    }
}

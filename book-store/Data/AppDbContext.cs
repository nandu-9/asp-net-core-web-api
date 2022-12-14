﻿using book_store.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace book_store.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setting up many-to-many relation between Book and Author tables (Configuration of Fluent API)

            modelBuilder.Entity<Book_Author>().
                HasOne(b => b.Book).
                WithMany(ba => ba.Book_Authors).
                HasForeignKey(bi => bi.BookId);

            modelBuilder.Entity<Book_Author>().
                HasOne(b => b.Author).
                WithMany(ba => ba.Book_Authors).
                HasForeignKey(bi => bi.AuthorId);
        }

        // DbSets name the tables
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book_Author> Books_Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}

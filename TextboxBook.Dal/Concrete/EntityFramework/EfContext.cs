using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using TextboxBook.Entity.Concrete;

namespace TextboxBook.Dal.Concrete.EntityFramework
{
    public class EfContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-2FDAH6B\SQLEXPRESS;Database=TextBook;Trusted_Connection=True");
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Order> Order { get; set; }

    }
}

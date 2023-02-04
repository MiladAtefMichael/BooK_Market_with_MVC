using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace BooK_Market.Models.Data
{
    public class DB:DbContext
    {
        public DB(DbContextOptions options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookAuthor>().HasKey(a => new { a.BookId,a.AuthId});

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<PriceOffers> PriceOffers { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }




    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Entities
{
    public class LibraryDbContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedData();
            //modelBuilder.Entity<Author>().HasData(new Author
            //{
            //    Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A3330"),
            //    Name = "Author 1",
            //    BirthDate = new DateTimeOffset(new DateTime(1960, 11, 18)),
            //    Email = "author1@xxx.com"
            //});
        }
    }
}

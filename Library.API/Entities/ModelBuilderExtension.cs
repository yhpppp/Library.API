using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Entities
{
    public static class ModelBuilderExtension
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A3330"),
                Name = "Author 1",
                BirthDate = new DateTimeOffset(new DateTime(1960, 11, 18)),
                Email = "author1@xxx.com",
                BirthPlace = "China"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6661"),
                Name = "王花花",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6662"),
                Name = "Author 2",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6663"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6664"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6665"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6666"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6667"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6668"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6669"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6670"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6671"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6672"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6673"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6674"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6675"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6676"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            },
            new Author
            {
                Id = new Guid("72D5B5F5-3008-49B7-B0D6-CC337F1A6677"),
                Name = "Author X",
                BirthDate = new DateTimeOffset(new DateTime(1999, 12, 31)),
                Email = "whh@flower.com",
                BirthPlace = "America"
            });

            //modelBuilder.Entity<Book>().HasData(new Book { })
        }
    }
}

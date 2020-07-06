﻿using Library.API.Data;
using Library.API.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    public class AuthorMockRepository : IAuthorRepository
    {

        //public IEnumerable<AuthorDto> GetAuthors()

        //{
        //    return LibraryMockData.Current.Authors;
        //}
        public List<AuthorDto> GetAuthors()

        {
            return LibraryMockData.Current.Authors.ToList();
        }
        public AuthorDto GetAuthor(Guid authorId)
        {
            var author = LibraryMockData.Current.Authors.FirstOrDefault(au => au.Id == authorId);
            return author;
        }


        public bool IsAuthorExists(Guid authorId)
        {
           return  LibraryMockData.Current.Authors.Any(au => au.Id == authorId);
        }

        public void AddAuthor(AuthorDto author)
        {
            author.Id = Guid.NewGuid();
            LibraryMockData.Current.Authors.Add(author);
        }

        public void DeleteAuthor(AuthorDto author)
        {
            LibraryMockData.Current.Books.RemoveAll(book => book.AuthorId == author.Id);
            LibraryMockData.Current.Authors.Remove(author);
        }
    }
}

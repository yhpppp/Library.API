using Library.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private  IAuthorRepository _authorRepository = null;

        private IBookRepository _bookRepository = null;
        public LibraryDbContext LibraryDbContext { get; }

        public RepositoryWrapper(LibraryDbContext libraryDbContext)
        {
            LibraryDbContext = libraryDbContext;
        }
        public IBookRepository Book => _bookRepository ?? new BookRepository(LibraryDbContext);

        public IAuthorRepository Author => _authorRepository ?? new AuthorRepository(LibraryDbContext);

    }
}

using Library.API.Data;
using Library.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    // 仓储实现
    public class BookMockRepository : IBookRepository
    {

        public List<BookDto> GetBooksForAuthor(Guid authorId)
        {
            return LibraryMockData.Current.Books.Where(b => b.AuthorId == authorId).ToList();
        }

        public BookDto GetBookForAuthor(Guid authorId, Guid bookId)
        {
            return LibraryMockData.Current.Books.FirstOrDefault(b => b.AuthorId == authorId && b.Id == bookId);
        }

        public void AddBook(BookDto book)
        {
            LibraryMockData.Current.Books.Add(book);
        }

        public void DeleteBook(BookDto book)
        {
            LibraryMockData.Current.Books.Remove(book);
        }

        public void UpdateBook(Guid authorId, Guid bookId, BookForUpdateDto book)
        {
           var originalBook =  GetBookForAuthor(authorId, bookId);
            originalBook.Title = book.Title;
            originalBook.Description = book.Description;
            originalBook.Pages = book.Pages;
        }
    }
}

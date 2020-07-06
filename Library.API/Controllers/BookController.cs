using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/authors/{authorId}/books")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public IBookRepository _bookRepository { get; }

        public IAuthorRepository _authorRepository { get; }
        public BookController(IBookRepository bookRepository, IAuthorRepository authorRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }
        //获取某个作者名下所有的书。
        [HttpGet]
        public ActionResult<List<BookDto>> getBooks(Guid authorId)
        {
            // 是否有该作者
            if (!_authorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }
            return _bookRepository.GetBooksForAuthor(authorId);
        }
        [HttpGet("{bookId}", Name = nameof(GetBook))]
        public ActionResult<BookDto> GetBook(Guid authorId, Guid bookId)
        {
            if (!_authorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }
            var targetBook = _bookRepository.GetBookForAuthor(authorId, bookId);
            if (targetBook == null)
            {
                return NotFound();
            }
            return targetBook;
        }

        [HttpPost]
        public IActionResult AddBook(Guid authorId, BookForCreationDto bookForCreationDto)
        {
            if (!_authorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }

            var newBook = new BookDto
            {
                Id = Guid.NewGuid(),
                Title = bookForCreationDto.Title,
                Description = bookForCreationDto.Description,
                Pages = bookForCreationDto.Pages,
                AuthorId = authorId
            };

            _bookRepository.AddBook(newBook);
            return CreatedAtRoute(nameof(GetBook), new { authorId = authorId, bookId = newBook.Id }, newBook);
        }

        [HttpDelete("{bookId}")]
        public IActionResult DeleteBook(Guid authorId, Guid bookId)
        {
            if(!_authorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }

            var book = _bookRepository.GetBookForAuthor(authorId, bookId);
            if(book == null)
            {
                return NotFound();
            }
            _bookRepository.DeleteBook(book);
            return NoContent();
        }

        [HttpPut("{bookId}")]
        public ActionResult<BookDto> UpdateBook(Guid authorId, Guid bookId,BookForUpdateDto updatedBook)
        {
            if (!_authorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }

            var book = _bookRepository.GetBookForAuthor(authorId, bookId);
            if(book == null)
            {
                return NotFound();
            }
            _bookRepository.UpdateBook(authorId, bookId, updatedBook);
            return _bookRepository.GetBookForAuthor(authorId, bookId);
        }
        [HttpPatch("{bookId}")]
        public IActionResult PartiallyUpdateBook(Guid authorId, Guid bookId, JsonPatchDocument<BookForUpdateDto> patchDocument) {
            if (!_authorRepository.IsAuthorExists(authorId))
            {
                return NotFound();
            }

            var book = _bookRepository.GetBookForAuthor(authorId, bookId);
            if(book == null)
            {
                return NotFound();
            }
            var bookToPatch = new BookForUpdateDto
            {
                Title = book.Title,
                Description = book.Description,
                Pages = book.Pages
            };

            patchDocument.ApplyTo(bookToPatch, ModelState);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _bookRepository.UpdateBook(authorId, bookId, bookToPatch);
            return NoContent();
        }
    }
}

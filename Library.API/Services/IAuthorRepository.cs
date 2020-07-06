using Library.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    // 仓储接口
    public interface IAuthorRepository
    {
        List<AuthorDto> GetAuthors();
        AuthorDto GetAuthor(Guid authorId);
        bool IsAuthorExists(Guid authorId);

        void AddAuthor(AuthorDto author);

        void DeleteAuthor(AuthorDto author);
    }
}

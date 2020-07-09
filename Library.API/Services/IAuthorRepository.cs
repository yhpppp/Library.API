using Library.API.Entities;
using Library.API.Helper;
using Library.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    // 仓储接口
    public interface IAuthorRepository : IRepositoryBase<Author>, IRepositoryBase2<Author, Guid>
    {
        //List<AuthorDto> GetAuthors();
        //AuthorDto GetAuthor(Guid authorId);
        //bool IsAuthorExists(Guid authorId);

        //void AddAuthor(AuthorDto author);

        //void DeleteAuthor(AuthorDto author);
        Task<PagedList<Author>> GetAllAsync(AuthorResourceParameters parameters);
    }
}

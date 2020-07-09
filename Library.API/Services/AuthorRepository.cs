using Library.API.Entities;
using Library.API.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Services
{
    public class AuthorRepository:RepositoryBase<Author,Guid>,IAuthorRepository
    {
        public AuthorRepository(DbContext dbContext) : base(dbContext)
        {
            
        }

        public Task<PagedList<Author>> GetAllAsync(AuthorResourceParameters parameters)
        {
            IQueryable<Author> queryableAuthors = DbContext.Set<Author>();
            return PagedList<Author>.CreateAsync(queryableAuthors, parameters.PageNumber, parameters.PageSize);
        }
    }
}

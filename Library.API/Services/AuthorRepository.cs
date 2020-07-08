﻿using Library.API.Entities;
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
    }
}
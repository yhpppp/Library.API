using AutoMapper;
using Library.API.Entities;
using Library.API.Extensions;
using Library.API.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Helper
{
    public class LibraryMappingProfile : Profile
    {

        public LibraryMappingProfile()
        {
            CreateMap<Author, AuthorDto>()
               .ForMember(dest => dest.Age, config =>
                   config.MapFrom(src => src.BirthDate.GetCurrentAge()));
            CreateMap<AuthorForCreationDto, Author>();
            CreateMap<Book, BookDto>();
            CreateMap<BookForCreationDto, Book>();
            CreateMap<BookForUpdateDto, Book>();
        }
    }
}

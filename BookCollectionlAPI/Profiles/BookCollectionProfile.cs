using AutoMapper;
using BookCollectionAPI.Dtos;
using BookCollectionAPI.Models;

namespace BookCollectionAPI.Profiles
{
    public class BookCollectionProfile : Profile
    {
        public BookCollectionProfile() 
        {
            CreateMap<Book, BookCollectionReadDto>();

            CreateMap<BookCollectionReadDto, Book>();
           

        }
    }
}

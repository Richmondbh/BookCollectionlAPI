using AutoMapper;
using BookCollectionAPI.Dtos;
using BookCollectionAPI.Models;

namespace BookCollectionAPI.Profiles
{
    public class BookCollectionProfile : Profile
    {
        public BookCollectionProfile() 
        {
            //Source-> Target
            CreateMap<Book, BookCollectionReadDto>();

            //Target -> Source
            CreateMap<BookCollectionCreateDto, Book>();
           

        }
    }
}

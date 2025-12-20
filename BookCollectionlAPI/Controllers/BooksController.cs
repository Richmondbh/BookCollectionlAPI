using AutoMapper;
using BookCollectionAPI.Data;
using BookCollectionAPI.Dtos;
using BookCollectionAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookCollectionAPI.Controllers
{

    // Route will be: api/books
    // Using [controller] keeps the route in sync if the controller name changes
    // [Route ("api/[controller]")]
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        //private readonly MockBookRepo _bookRepo = new MockBookRepo();
        private readonly IBookCollectionRepo _repository;
        private readonly IMapper _mapper;

        public BooksController(IBookCollectionRepo repository, IMapper mapper)
        {
            _repository = repository;

            _mapper = mapper;
        }


        //GET api/books/
        [HttpGet]
        public ActionResult<IEnumerable<BookCollectionReadDto>> GetAllBooks()
        {
            var bookItems = _repository.GetBooks();

            if (bookItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<BookCollectionReadDto>>(bookItems));
            }

            return NotFound();
        }

        //GET api/books/{id}
        [HttpGet("{id}", Name = "GetBookById")]
        public ActionResult<BookCollectionReadDto> GetBookById(int id)
        {
            var bookItem = _repository.GetBookById(id);

            if (bookItem != null)
            {
                return Ok(_mapper.Map<BookCollectionReadDto>(bookItem));
            }
            return NotFound();
        }

        //Post api/books/
        [HttpPost]
        public ActionResult<BookCollectionReadDto> CreateBook(BookCollectionCreateDto bookCreateDto)
        {
            var bookModel = _mapper.Map<Book>(bookCreateDto);
            _repository.CreateBook(bookModel);

            _repository.SaveChanges();

            var bookReadDto = _mapper.Map<BookCollectionReadDto>(bookModel);
            return CreatedAtRoute(
                nameof(GetBookById), new { id = bookReadDto.Id }, bookReadDto);


        }


        //PUT api/books/{id}
        [HttpPut("{id}")]
        public ActionResult Updatebook(int id, BookCollectionUpdateDto bookUpdateDto)
        {
            var bookModelFromRepo = _repository.GetBookById(id);

            if (bookModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(bookUpdateDto, bookModelFromRepo);

            _repository.UpdateBook(bookModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/books/{id}
        [HttpPatch("{id}")]
        public ActionResult PatialBookUpdate(int id, JsonPatchDocument<BookCollectionUpdateDto> patchDoc) 
        {
            var bookModelFromRepo = _repository.GetBookById(id);

            if (bookModelFromRepo == null)
            {
                return NotFound();
            }

            var bookPatch = _mapper.Map<BookCollectionUpdateDto>(bookModelFromRepo);
            patchDoc.ApplyTo(bookPatch, ModelState);

            if (!TryValidateModel(bookPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(bookPatch, bookModelFromRepo);
            _repository.UpdateBook(bookModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/commands/ {id}
        [HttpDelete("{id}")]

        public ActionResult DeleteBook (int id)
        {
            var bookModelFromRepo = _repository.GetBookById(id);

            if (bookModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteBook(bookModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }
    }
}


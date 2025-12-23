using AutoMapper;
using BookCollectionAPI.Data;
using BookCollectionAPI.Dtos;
using BookCollectionAPI.Models;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookCollectionReadDto>>> GetAllBooksAsync()
        {
            var bookItems = await _repository.GetBooksAsync();

            if (bookItems != null)
            {
                return Ok(_mapper.Map<IEnumerable<BookCollectionReadDto>>(bookItems));
            }

            return NotFound();
        }

        //GET api/books/{id}
        [AllowAnonymous]
        [HttpGet("{id:int}", Name = "GetBookByIAsync")]
        public async Task<ActionResult<BookCollectionReadDto>> GetBookByIdAsync(int id)
        {
            var bookItem = await _repository.GetBookByIdAsync(id);

            if (bookItem != null)
            {
                return Ok(_mapper.Map<BookCollectionReadDto>(bookItem));
            }
            return NotFound();
        }

        //Post api/books/
        [Authorize]
        [HttpPost]
        public async Task<ActionResult<BookCollectionReadDto>> CreateBookAsync([FromBody]BookCollectionCreateDto bookCreateDto)
        {
            var bookModel = _mapper.Map<Book>(bookCreateDto);
            _repository.CreateBook(bookModel);

            await _repository.SaveChangesAsync();

            var bookReadDto = _mapper.Map<BookCollectionReadDto>(bookModel);
            return CreatedAtRoute
                (
                nameof(GetBookByIdAsync), 
                new { id = bookReadDto.Id },
                bookReadDto);


        }


        //PUT api/books/{id}
        [Authorize]
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatebookAsync(int id, BookCollectionUpdateDto bookUpdateDto)
        {
            var bookModelFromRepo = await  _repository.GetBookByIdAsync(id);

            if (bookModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(bookUpdateDto, bookModelFromRepo);

            _repository.UpdateBook(bookModelFromRepo);

            await _repository.SaveChangesAsync();

            return NoContent();
        }

        //PATCH api/books/{id}
        [Authorize(Roles = "Admin")]
        [HttpPatch("{id}")]
        public async Task<ActionResult> PatialBookUpdateAsync(int id, JsonPatchDocument<BookCollectionUpdateDto> patchDoc) 
        {
            var bookModelFromRepo = await _repository.GetBookByIdAsync(id);

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

            await _repository.SaveChangesAsync();

            return NoContent();
        }

        //DELETE api/commands/ {id}
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBookAsync (int id)
        {
            var bookModelFromRepo = await _repository.GetBookByIdAsync(id);

            if (bookModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteBook(bookModelFromRepo);

           await _repository.SaveChangesAsync();

            return NoContent();
        }
    }
}


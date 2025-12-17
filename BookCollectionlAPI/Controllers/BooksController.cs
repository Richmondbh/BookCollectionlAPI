using BookCollectionAPI.Data;
using BookCollectionAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookCollectionAPI.Controllers
{

    // Route will be: api/books
    // Using [controller] keeps the route in sync if the controller name changes
    // [Route ("api/[controller]")]
    [ApiController]
    [Route ("api/books")]
    public class BooksController: ControllerBase
    {
        //private readonly MockBookRepo _bookRepo = new MockBookRepo();
        private readonly IBookCollectionRepo _repository;

        public BooksController(IBookCollectionRepo repository)
        {
            _repository = repository;
        }

       
        //GET api/books/
        [HttpGet]
        public ActionResult <IEnumerable<Book>> GetAllBooks()
        {
            var bookItems = _repository.GetBooks();

            return Ok(bookItems);
           
        }

        //GET api/books/{id}
        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var bookItem= _repository.GetBookById(id);
            return Ok(bookItem);
        }
    }
}

using BookCollectionAPI.Data;
using BookCollectionAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookCollectionAPI.Controllers
{

    // Route will be: api/books
    // Using [controller] keeps the route in sync if the controller name changes
    [Route ("api/[controller]")]
    [ApiController]
    public class BooksController: ControllerBase
    {

        private readonly MockBookRepo _bookRepo = new MockBookRepo();
        //GET api/books/
        [HttpGet]
        public ActionResult <IEnumerable<Book>> GetAllBooks()
        {
            var bookItems =_bookRepo.GetBooks();

            return Ok(bookItems);
        }

        //GET api/books/{id}
        [HttpGet("{id}")]
        public ActionResult<Book> GetBookById(int id)
        {
            var bookItem=_bookRepo.GetBookById(id);
            return Ok(bookItem);
        }
    }
}

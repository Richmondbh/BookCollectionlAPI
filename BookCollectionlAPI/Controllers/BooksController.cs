using Microsoft.AspNetCore.Mvc;

namespace BookCollectionAPI.Controllers
{

    // Route will be: api/books
    // Using [controller] keeps the route in sync if the controller name changes
    [Route ("api/[controller]")]
    [ApiController]
    public class BooksController: ControllerBase
    {

    }
}

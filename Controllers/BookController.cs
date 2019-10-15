using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using webApiMultipleDb.Models;
using webApiMultipleDb.Repository;

namespace webApiMultipleDb.Controllers
{
    [Route("api/[controller]")] 
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository) {
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetAllBooks()
        {
            var books = await _bookRepository.GetBooks();
             return Ok(books);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> Post([FromBody]Book book)
        {            
           await _bookRepository.AddBook(book);
           return Ok();
        }
    }
}
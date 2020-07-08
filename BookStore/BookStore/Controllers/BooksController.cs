using BookStore.ModelDtos;
using BookStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService service;

        public BooksController(IBookService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var books = service.GetAll();
            return Ok(books);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var book = service.GetById(id);
            return Ok(book);
        }

        [HttpGet]
        [Route("getByAuthor")]
        public IActionResult GetByAuthor(string author)
        {
            var books = service.GetByAuthor(author);
            return Ok(books);
        }


        [HttpPost]
        public IActionResult Create(BookDto book)
        {
            service.Create(book);
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            service.Delete(id);
            return Ok();
        }


        [HttpPut]
        public IActionResult Update(BookDto book)
        {
            service.Update(book);
            return Ok();
        }


    }
}
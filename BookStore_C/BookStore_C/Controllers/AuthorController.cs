using BookStore_C.BL.Interfaces;
using BookStore_C.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_C.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Author> GetAll()
        {
           return _authorService.GetAll();
        }

        [HttpGet("GetById")]
        public Author? GetById(int id)
        {
            return _authorService.GetById(id);
        }

        [HttpPost("Add")]
        public void Add([FromBody]Author author)
        {
            _authorService.Add(author);
        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            _authorService.Delete(id);
        }
    }
}

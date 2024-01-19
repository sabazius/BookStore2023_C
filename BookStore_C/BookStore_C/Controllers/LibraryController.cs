using BookStore_C.BL.Interfaces;
using BookStore_C.Models.Requests;
using BookStore_C.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_C.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;
        public LibraryController(
            ILibraryService libraryService)
        {
            _libraryService = libraryService;
        }

        [HttpPost("GetAllBooksByAuthor")]
        public GetAllBooksByAuthorResponse?
            GetAllBooksByAuthor([FromBody]
                GetAllBooksByAuthorRequest request)
        {
            return _libraryService
                .GetAllBooksByAuthorAfterDate(request);
        }

        [HttpPost("TestEndpoint")]
        public string TestEndpoint([FromBody] 
            TestRequest request)
        {
            return "Ok";
        }

    }
}

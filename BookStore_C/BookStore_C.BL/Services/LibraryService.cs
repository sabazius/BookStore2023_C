using BookStore_C.BL.Interfaces;
using BookStore_C.Models.Requests;
using BookStore_C.Models.Responses;

namespace BookStore_C.BL.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;

        public LibraryService(
            IBookService bookService,
            IAuthorService authorService)
        {
            _bookService = bookService;
            _authorService = authorService;
        }

        public GetAllBooksByAuthorResponse? 
            GetAllBooksByAuthorAfterDate(
                GetAllBooksByAuthorRequest request)
        {
            var books = _bookService
                .GetAllBooksByAuthor(request.AuthorId);

            var author = _authorService
                .GetById(request.AuthorId);

            if (author == null) return null;

            var result = new GetAllBooksByAuthorResponse
            {
                Author = author, //Get author
                Books =  books
                    .Where(b =>
                        b.ReleaseDate >= request.AfterDate)
                    .ToList()
            };

            return result;
        }
    }
}

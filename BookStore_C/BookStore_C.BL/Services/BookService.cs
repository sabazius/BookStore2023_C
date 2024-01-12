using BookStore_C.BL.Interfaces;
using BookStore_C.DL.Interfaces;
using BookStore_C.Models.Models;

namespace BookStore_C.BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> GetAllBooksByAuthor(int authorId)
        {
            return _bookRepository.GetAllBooksByAuthor(authorId);
        }
    }
}

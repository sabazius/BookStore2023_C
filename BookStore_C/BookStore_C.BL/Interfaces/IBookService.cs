using BookStore_C.Models.Models;

namespace BookStore_C.BL.Interfaces
{
    public interface IBookService
    {
        List<Book> GetAllBooksByAuthor(int authorId);
    }
}

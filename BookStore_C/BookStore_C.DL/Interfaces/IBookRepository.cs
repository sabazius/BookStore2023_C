using BookStore_C.Models.Models;

namespace BookStore_C.DL.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAllBooksByAuthor(int authorId);
    }
}

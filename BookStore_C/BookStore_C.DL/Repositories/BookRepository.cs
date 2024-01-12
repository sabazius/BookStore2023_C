using BookStore_C.DL.Interfaces;
using BookStore_C.DL.MemoryDb;
using BookStore_C.Models.Models;

namespace BookStore_C.DL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public List<Book> GetAllBooksByAuthor(int authorId)
        {
            return InMemoryDb.BookData.Where(b => b.AuthorId == authorId).ToList();
        }
    }
}

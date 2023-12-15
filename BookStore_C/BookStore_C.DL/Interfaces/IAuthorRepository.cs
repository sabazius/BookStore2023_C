using BookStore_C.Models.Models;

namespace BookStore_C.DL.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();

        Author? GetById(int id);

        void Add(Author author);

        void Delete(int id);
    }
}

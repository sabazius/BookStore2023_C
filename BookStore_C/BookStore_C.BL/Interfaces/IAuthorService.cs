using BookStore_C.Models.Models;

namespace BookStore_C.BL.Interfaces
{
    public interface IAuthorService
    {
        List<Author> GetAll();

        Author? GetById(int id);

        void Add(Author author);

        void Delete(int id);
    }
}

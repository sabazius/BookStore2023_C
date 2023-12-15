using BookStore_C.DL.Interfaces;
using BookStore_C.DL.MemoryDb;
using BookStore_C.Models.Models;

namespace BookStore_C.DL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public List<Author> GetAll()
        {
            return InMemoryDb.AuthorData;
        }

        public Author? GetById(int id)
        {
            return InMemoryDb.AuthorData
                .FirstOrDefault(a => a.Id == id);
        }

        public void Add(Author author)
        {
            InMemoryDb.AuthorData.Add(author);
        }

        public void Delete(int id)
        {
            var author = GetById(id);

            if (author != null)
            {
                InMemoryDb.AuthorData.Remove(author);
            }
        }
    }
}

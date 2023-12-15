using BookStore_C.BL.Interfaces;
using BookStore_C.DL.Interfaces;
using BookStore_C.Models.Models;

namespace BookStore_C.BL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public List<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author? GetById(int id)
        {
            if(id <= 0) return null;

            return _authorRepository.GetById(id);
        }

        public void Add(Author author)
        {
            _authorRepository.Add(author);
        }

        public void Delete(int id)
        {
            _authorRepository.Delete(id);
        }
    }
}

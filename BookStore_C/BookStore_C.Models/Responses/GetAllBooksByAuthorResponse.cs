using BookStore_C.Models.Models;

namespace BookStore_C.Models.Responses
{
    public class GetAllBooksByAuthorResponse
    {
        public Author Author { get; set; }

        public List<Book> Books { get; set; }
    }
}

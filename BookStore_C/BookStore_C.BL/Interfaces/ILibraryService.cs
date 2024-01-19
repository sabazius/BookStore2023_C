using BookStore_C.Models.Requests;
using BookStore_C.Models.Responses;

namespace BookStore_C.BL.Interfaces
{
    public interface ILibraryService
    {
        GetAllBooksByAuthorResponse?
            GetAllBooksByAuthorAfterDate(
                GetAllBooksByAuthorRequest request);

        int GetAllBooksCount(int inputCount, int authorId);
    }
}

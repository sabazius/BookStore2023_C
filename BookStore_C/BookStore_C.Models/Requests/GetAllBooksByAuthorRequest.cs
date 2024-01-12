namespace BookStore_C.Models.Requests
{
    public class GetAllBooksByAuthorRequest
    {
        public int AuthorId { get; set; }

        public DateTime AfterDate { get; set; }
    }
}

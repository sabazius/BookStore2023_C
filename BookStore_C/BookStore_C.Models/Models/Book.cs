namespace BookStore_C.Models.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int AuthorId { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}

using BookStore_C.Models.Models;

namespace BookStore_C.DL.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Author> AuthorData =
            new List<Author>()
            {
                new Author()
                {
                    Id = 1,
                    Name = "Author 1",
                    BirthDay = DateTime.Now
                },
                new Author()
                {
                    Id = 2,
                    Name = "Author 2",
                    BirthDay = DateTime.Now
                },
                new Author()
                {
                    Id = 3,
                    Name = "Author 3",
                    BirthDay = DateTime.Now
                }
            };
    }
}

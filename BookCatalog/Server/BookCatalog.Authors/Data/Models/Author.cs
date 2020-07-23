using System.Collections.Generic;

namespace BookCatalog.Authors.Data.Models
{
    public class Author
    {
        public string AuthorId { get; set; }

        public string UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Biography { get; set; }

        public List<Book> Books { get; set; }
    }
}

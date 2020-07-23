namespace BookCatalog.Authors.Data.Models
{
    public class Book
    {
        public string BookId { get; set; }

        public string AuthorId { get; set; }

        public Author Author {get;set;}

        public string Title { get; set; }
    }
}

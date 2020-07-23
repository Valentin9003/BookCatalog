using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Common.Messages
{
    public class BookAddedMessage
    {
        public string BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Genre { get; set; }
    }
}

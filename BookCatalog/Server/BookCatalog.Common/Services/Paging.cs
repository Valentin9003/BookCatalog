using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog.Common.Services
{
    public class Paging
    {
        public int TotalPages { get; set; }

        public int CurrentPage { get; set; }

        public bool HaveNextPage { get; set; }
    }
}

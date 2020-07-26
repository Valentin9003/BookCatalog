using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Statistics.Data.Models
{
    public class Statistic
    {
        public string StatisticId { get; set; }

        public int TotalAuthors { get; set; }

        public int TotalBooks { get; set; }
    }
}

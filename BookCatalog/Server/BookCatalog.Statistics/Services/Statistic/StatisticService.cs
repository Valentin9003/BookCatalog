using BookCatalog.Services;
using BookCatalog.Statistics.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Statistics.Services.Statistic
{
    public class StatisticService : DataService<BookCatalog.Statistics.Data.Models.Statistic>,IStatisticService
    {
        public StatisticService(StatisticsDbContext db)
            : base(db)
        {

        }
    }
}

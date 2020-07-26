using BookCatalog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookCatalog.Statistics.Services.Statistic
{
    public interface IStatisticService : IDataService<BookCatalog.Statistics.Data.Models.Statistic>
    {
    }
}

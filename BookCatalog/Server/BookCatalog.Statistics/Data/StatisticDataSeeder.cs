using BookCatalog.Common.Services;
using BookCatalog.Statistics.Data.Models;
using System;
using System.Linq;

namespace BookCatalog.Statistics.Data
{
    public class StatisticDataSeeder : IDataSeeder
    {
        private readonly StatisticsDbContext db;
        public StatisticDataSeeder(StatisticsDbContext db)
        {
            this.db = db;
        }
        private Statistic Data = new Statistic
        {
            StatisticId = Guid.NewGuid().ToString(),
            TotalAuthors = 0,
            TotalBooks = 0,
        };

        public void SeedData()
        {
            if (db.Statistics.Any())
            {
                return;
            }

            db.Statistics.Add(Data);
            db.SaveChanges();
        }
    }
}

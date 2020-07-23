using Microsoft.EntityFrameworkCore;
using System;
using BookCatalog.Statistics.Data.Models;

namespace BookCatalog.Statistics.Data.Configurations
{
    public class StatisticConfiguration : IEntityTypeConfiguration<Statistic>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Statistic> builder)
        {
            builder.HasKey(k => k.StatisticId);

        }
    }
}

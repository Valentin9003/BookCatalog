using BookCatalog.Common.Models;
using System.Threading.Tasks;

namespace BookCatalog.Services
{
    public interface IDataService<in TEntity>
        where TEntity : class
    {
        Task MarkMessageAsPublished(int id);

        Task Save(TEntity entity, params Message[] messages);
    }
}

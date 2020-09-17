using System.Collections.Generic;
using System.Threading.Tasks;

namespace Asc.Azure.Abstractions
{
    public interface ITableRepository<T>
    {
        Task<T> Get(string partitionKey, string rowKey);
        Task<IList<T>> GetByPartition(string partitionKey);
        Task Remove(T entity);
        Task<T> Save(T entity);
    }
}

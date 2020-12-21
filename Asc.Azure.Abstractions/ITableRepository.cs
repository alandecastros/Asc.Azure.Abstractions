using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Asc.Azure.Abstractions
{
    public interface ITableRepository<T> where T : TableEntity, new()
    {
        Task<T> GetAsync(string rowKey, string partitionKey = null);
        Task<IEnumerable<T>> GetByPartitionAsync(string partitionKey, CancellationToken ct = default,
            Action<IList<T>> onProgress = null);
        Task<IEnumerable<T>> GetByQueryAsync(TableQuery<T> query, CancellationToken ct = default,
            Action<IList<T>> onProgress = null);
        Task DeleteAsync(T entity);
        Task<T> SaveAsync(T entity);
    }
}

using System;
using System.Threading.Tasks;

namespace Asc.Azure.Abstractions
{
    public interface IObjectBlobStorage<T>
    {
        Task<Uri> Save(string filename, T obj);
        Task<T> Get(Uri uri);
    }
}

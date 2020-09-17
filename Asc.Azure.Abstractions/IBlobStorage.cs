using System;
using System.Threading.Tasks;

namespace Asc.Azure.Abstractions
{
    public interface IBlobStorage
    {
        Task<Uri> Save(string filename, byte[] bytes);
        Task<byte[]> Get(Uri uri);
    }
}

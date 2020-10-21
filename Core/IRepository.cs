using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace Core
{
    public interface IRepository<T>
    {
        Task<T> Read(String id);
        Task<IList<T>> Read();
        Task<int> Add (T entity);
        Task<int> Update(T entity);
        Task<int> Delete(String id); 
    }
}

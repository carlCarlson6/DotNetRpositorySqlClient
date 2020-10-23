using System.Collections.Generic;
using System.Threading.Tasks;
using Criteria;

namespace Core
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IList<Product>> SearchByCreteria(SearchCriteria criteria);
    }
}

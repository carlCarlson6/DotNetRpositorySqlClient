using System.Collections.Generic;
using Criteria;

namespace Core
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> SearchByCreteria(SearchCriteria criteria);
    }
}

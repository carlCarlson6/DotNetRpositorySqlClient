using System.Collections.Generic;
using System.Threading.Tasks;
using Criteria;

namespace Core
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<IList<Product>> SearchByCreteria(SearchCriteria criteria);
    }
}

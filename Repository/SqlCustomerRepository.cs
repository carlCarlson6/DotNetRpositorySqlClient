using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using Criteria;

namespace Repository
{
    public class SqlCustomerRepository : ICustomerRepository
    {
        public Task<int> Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> Read(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Customer>> Read()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Product>> SearchByCreteria(SearchCriteria criteria)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}

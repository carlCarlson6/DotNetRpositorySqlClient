using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using Criteria;
using System.Data.SqlClient;

namespace Repository
{
    public class SqlCustomerRepository : SqlBaseRepository, ICustomerRepository
    {
        SqlCustomerRepository(String sqlServerConnectionString) : base(sqlServerConnectionString) { }

        public Task<int> Add(Customer entity)
        {
            throw new NotImplementedException("not implemented");
        }
        public Task<int> Delete(string id)
        {
            throw new NotImplementedException();
        }
        public Task<Customer> Read(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Customer>> Read()
        {
            SqlDataReader dataReader;
            
            using(SqlConnection connection = this.Connection)
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("", connection))
                {
                    dataReader = await command.ExecuteReaderAsync();
                }
            }

            while(dataReader.Read())
            {
                String customer = dataReader.GetString(0);
            }

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

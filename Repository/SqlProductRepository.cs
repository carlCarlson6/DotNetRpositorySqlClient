using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Core;
using Dapper;
using System.Linq;
using Criteria;

namespace Repository
{
    public class SqlProductRepository : IProductRepository
    {
        private SqlConnection connection;
        public SqlProductRepository(String sqlServerConnectionString) => this.connection = SqlServerConnection.GetConnection(sqlServerConnectionString);

        public async Task<int> Add(Product entity)
        {
            int resultCode = await this.connection.ExecuteAsync(ProductQueries.Add, entity);
            return resultCode;
        }
        
        public async Task<Product> Read(string id)
        {
            Product product = await connection.QueryFirstOrDefaultAsync<Product>(ProductQueries.Read, new {Id=id});
            return product;
        }

        public async Task<IList<Product>> Read()
        {
            IList<Product> products = (await connection.QueryAsync<Product>(ProductQueries.ReadAll)).ToList();
            return products;
        }

        public async Task<int> Delete(string id)
        {
            int resultCode = await this.connection.ExecuteAsync(ProductQueries.Delete, new {Id=id});
            return resultCode;
        }
        
        public async Task<int> Update(Product entity)
        {
            int resultCode = await this.connection.ExecuteAsync(ProductQueries.Update, entity);
            return resultCode;
        }

        public async Task<IList<Product>> SearchByCreteria(SearchCriteria criteria)
        {
            String query = criteria.ToString();
            IList<Product> products = (await connection.QueryAsync<Product>(query)).ToList();
            throw new NotImplementedException();
        }

    }
}

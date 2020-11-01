using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Core;
using Dapper;
using System.Linq;
using Criteria;
using System.Data.Common;

namespace Repository
{
    public class SqlProductRepository : IProductRepository
    {
        private String connectionString;
        public SqlProductRepository(String sqlServerConnectionString) => this.connectionString = sqlServerConnectionString;

        private DbConnection Connection { get => SqlServerConnection.GetConnection(this.connectionString); }

        public async Task<int> Add(Product entity)
        {
            using(DbConnection connection = Connection)
            {
                await connection.OpenAsync();
                int resultCode = await connection.ExecuteAsync(ProductQueries.Add, entity);
                return resultCode;
            }
        }
        
        public async Task<Product> Read(string id)
        {
            using(DbConnection connection = Connection)
            {
                await connection.OpenAsync();
                Product product = await connection.QueryFirstOrDefaultAsync<Product>(ProductQueries.Read, new {Id=id});
                return product;
            }
        }

        public async Task<IList<Product>> Read()
        {
            using(DbConnection connection = Connection)
            {
                await connection.OpenAsync();   
                IList<Product> products = (await connection.QueryAsync<Product>(ProductQueries.ReadAll)).ToList();
                await connection.QueryAsync(ProductQueries.ReadAll);
                return products;
            }
        }

        public async Task<int> Delete(string id)
        {
            using(DbConnection connection = Connection)
            {
                await connection.OpenAsync();   
                int resultCode = await connection.ExecuteAsync(ProductQueries.Delete, new {Id=id});
                return resultCode;
            }
        }
        
        public async Task<int> Update(Product entity)
        {
            using(DbConnection connection = Connection)
            {
                await connection.OpenAsync();
                int resultCode = await connection.ExecuteAsync(ProductQueries.Update, entity);
                return resultCode;
                   
            }
        }

        public async Task<IList<Product>> SearchByCreteria(SearchCriteria criteria)
        {
            String query = criteria.ToString();
                
            using(DbConnection connection = Connection)
            {
                await connection.OpenAsync();
                IList<Product> products = (await connection.QueryAsync<Product>(query)).ToList();
                throw new NotImplementedException();
            }

        }

    }
}

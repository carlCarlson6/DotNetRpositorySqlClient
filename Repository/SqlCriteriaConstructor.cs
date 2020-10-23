using System;
using System.Collections.Generic;
using Criteria;

namespace Repository
{
    public class SqlCriteriaConstructor : ISerchCriteriaConstructor<String>
    {
        public string Construct(SearchCriteria criteria, String tableName)
        {
            String query = "SELECT * FROM " + tableName;

            

            return query;
        }

        private String AddFilters(List<Filter> filters, String query)
        {
            query = query + " WHERE";
            filters.ForEach(filter => query = this.AddFilter(filter, query));
            return query;
        }

        private String AddFilter(Filter filter, String query)
        {
            //query = String.Concat(query, " WHERE" , filter.);

            return query;
        }
    }
}

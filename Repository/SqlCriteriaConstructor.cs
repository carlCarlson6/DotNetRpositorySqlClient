using System;
using System.Collections.Generic;
using Criteria;

namespace Repository
{
    public class SqlCriteriaConstructor : ISerchCriteriaConstructor<String>
    {
        public string Construct(SearchCriteria criteria, String tableName)
        {
            String query = String.Concat("SELECT * FROM", " ", tableName);
            query = this.AddFilters(criteria.Filters, query);
            query = String.Concat(query, ";");
            return query;
        }

        private String AddFilters(List<Filter> filters, String query)
        {
            query = String.Concat(query, " " ,"WHERE");

            for(int i=0; i<filters.Count; i++)
            {
                query = this.AddFilter(filters[i], query);
                query = (i+1 < filters.Count)? String.Concat(query, " ", "AND") : query;
            }

            return query;
        }

        private String AddFilter(Filter filter, String query) => String.Concat(query, " ", filter.Field, filter.OperatorFilter, filter.ValueFilter.Value);

    }

}

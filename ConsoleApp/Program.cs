using Criteria;
using Repository;
using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ISerchCriteriaConstructor<String> criteriaConstructor = new SqlCriteriaConstructor();

            List<Filter> filters = new List<Filter>()
            {
                new Filter("Name", OperatorFilter.Equal, new ValueFilter("Juan")),
                new Filter("Price", OperatorFilter.GreaterThan, new ValueFilter("32.5")),
            };

            SearchCriteria criteria = new SearchCriteria(filters);

            String sqlQuery = criteriaConstructor.Construct(criteria, "Products");
            Console.WriteLine(sqlQuery);
        }
    }
}

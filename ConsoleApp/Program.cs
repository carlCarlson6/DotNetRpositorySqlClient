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

            Console.WriteLine("--------------------------------");

            ISerchCriteriaConstructor<String> criteriaConstructor2 = new SqlCriteriaConstructor();

            List<Filter> filters1 = new List<Filter>()
            {
                new Filter("CustomerName", OperatorFilter.Equal, new ValueFilter("Alfreds Futterkiste")),
                new Filter("Country", OperatorFilter.Equal, new ValueFilter("Germany")),
                new Filter("Address", OperatorFilter.Equal, new ValueFilter("Obere Str. 57"))
            };

            SearchCriteria criteria2 = new SearchCriteria(filters1);

            String sqlQuery2 = criteriaConstructor.Construct(criteria2, "Customers");
            Console.WriteLine(sqlQuery2);

        }
        
    }
}

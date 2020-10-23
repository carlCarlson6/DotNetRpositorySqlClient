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
            List<Filter> productoFilters = new List<Filter>()
            {
                new Filter("Name", OperatorFilter.Equal, new ValueFilter("Juan")),
                new Filter("Price", OperatorFilter.GreaterThan, new ValueFilter("32.5")),
            };

            SearchCriteria productCriteria = new SearchCriteria("Products", productoFilters);
            Console.WriteLine(criteria.ToString());

            Console.WriteLine("--------------------------------");

        }

    }
}

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
            List<Filter> filters = new List<Filter>()
            {
                new Filter("Name", OperatorFilter.Equal, new ValueFilter("Juan")),
                new Filter("Price", OperatorFilter.GreaterThan, new ValueFilter("32.5")),
            };

            SearchCriteria criteria = new SearchCriteria("Products", filters);
            Console.WriteLine(criteria.ToString());

            Console.WriteLine("--------------------------------");

            List<Filter> filters1 = new List<Filter>()
            {
                new Filter("CustomerName", OperatorFilter.Equal, new ValueFilter("Alfreds Futterkiste")),
                new Filter("Country", OperatorFilter.Equal, new ValueFilter("Germany")),
                new Filter("Address", OperatorFilter.Equal, new ValueFilter("Obere Str. 57"))
            };

            SearchCriteria criteria2 = new SearchCriteria("Customers", filters1);
            Console.WriteLine(criteria2.ToString());
        }

    }
}

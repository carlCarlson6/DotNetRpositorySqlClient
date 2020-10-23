using System.Collections.Generic;

namespace Criteria
{
    public class SearchCriteria
    {
        private List<Filter> filters;
        private Order order;
        private Pagination pagination;

        public SearchCriteria(List<Filter> filters, Order order, Pagination pagination)
        {
            this.filters = filters;
            this.order = order;
            this.pagination = pagination;
        }

    }
}

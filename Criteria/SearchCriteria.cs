using System.Collections.Generic;

namespace Criteria
{
    public class SearchCriteria
    {
        private List<Filter> filters;
        private Order order;
        private Pagination pagination;

        public List<Filter> Filters { get => this.filters; }
        private Order Order { get => this.order; }
        private Pagination Pagination { get => this.pagination; }


        public SearchCriteria(List<Filter> filters, Order order = null, Pagination pagination = null)
        {
            this.filters = filters;
            this.order = order;
            this.pagination = pagination;
        }

    }
}

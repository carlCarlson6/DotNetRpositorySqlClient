using System;
namespace Criteria
{
    public class Filter
    {
        private String field;
        private String operatorFilter;
        private ValueFilter value;

        public Filter(String field, String operatorFilter, ValueFilter value)
        {
            this.field = field;
            this.operatorFilter = operatorFilter;
            this.value = value;
        }  
    }
}
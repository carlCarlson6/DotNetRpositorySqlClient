using System;
namespace Criteria
{
    public class Filter
    {
        private String field;
        private String operatorFilter;
        private ValueFilter value;

        public String Field { get => this.Field; }
        public String OperatorFilter { get => this.operatorFilter; }
        public String Value { get => this.value; }

        public Filter(String field, String operatorFilter, ValueFilter value)
        {
            this.field = field;
            this.operatorFilter = operatorFilter;
            this.value = value;
        }  
    }
}
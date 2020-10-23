using System;

namespace Criteria
{
    public interface ISerchCriteriaConstructor<T>
    {
        T Construct(SearchCriteria criteria, String tableName);
    }
}

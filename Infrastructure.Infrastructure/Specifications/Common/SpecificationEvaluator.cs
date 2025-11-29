using Microsoft.EntityFrameworkCore;
using ReelsCommerceSystem.Domain.Common;
using System.Xml.XPath;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Common;

public static class SpecificationEvaluator<T> where T : BaseEntity
{
    public static IQueryable<T> GetQuery(
        IQueryable<T> inputQuery,
        ISpecification<T> specification,
        bool applyPaging = true)
    {
        var query = inputQuery;

        if (specification.Criteria != null)
        {
            query = query.Where(specification.Criteria);
        }

        if (specification.Includes != null && specification.Includes.Any())
        {
            query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));
        }
        if (specification.IncludeStrings != null && specification.IncludeStrings.Any())
        {
            query = specification.IncludeStrings
                .Aggregate(query, (current, include) => current.Include(include));
        }

        // Apply ordering
        if (specification.OrderBy != null && specification.SortOrder == XmlSortOrder.Ascending)
        {
            query = query.OrderBy(specification.OrderBy);
        }
        else if (specification.OrderBy != null && specification.SortOrder == XmlSortOrder.Descending)
        {
            query = query.OrderByDescending(specification.OrderBy);
        }

        // Apply paging if required
        if (applyPaging && specification.IsPagingEnabled)
        {
            query = query
               .Skip((specification.PageIndex!.Value - 1) * specification.PageSize!.Value)
               .Take(specification.PageSize.Value);
        }

        foreach (var modifier in specification.QueryModifiers)
        {
            query = modifier(query);
        }

        return query;
    }
}


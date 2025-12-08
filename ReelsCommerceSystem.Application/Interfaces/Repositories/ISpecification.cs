using ReelsCommerceSystem.Domain.Common;
using System.Linq.Expressions;
using System.Xml.XPath;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Common;

public interface ISpecification<T> where T : BaseEntity
{
    List<Func<IQueryable<T>, IQueryable<T>>> QueryModifiers { get; }
    Expression<Func<T, bool>>? Criteria { get; }
    List<Expression<Func<T, object>>>? Includes { get; }
    List<Func<IQueryable<T>, IQueryable<T>>> IncludeChains { get; }////////

    List<string> IncludeStrings { get; }
    Expression<Func<T, object>>? OrderBy { get; }
    XmlSortOrder SortOrder { get; }
    int? PageSize { get; }
    int? PageIndex { get; }
    bool IsPagingEnabled { get; }
}

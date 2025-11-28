using ReelsCommerceSystem.Domain.Common;
using System.Linq.Expressions;
using System.Xml.XPath;
using Microsoft.EntityFrameworkCore;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Common;

public class Specification<T>(
                            Expression<Func<T, bool>>? criteria = null,
                            Expression<Func<T, object>>? orderBy = null, 
                            XmlSortOrder sortOrder = XmlSortOrder.Ascending,
                            int? pageIndex = null, 
                            int? pageSize = null
                            ) : ISpecification<T> where T : BaseEntity
{


    #region Properties
    public List<Func<IQueryable<T>, IQueryable<T>>> QueryModifiers { get; } = new();
    public Expression<Func<T, bool>>? Criteria { get; private set; } = criteria;
    public List<Expression<Func<T, object>>> Includes { get; set; } = new();
    public List<string> IncludeStrings { get; } = new List<string>();
    public Expression<Func<T, object>>? OrderBy { get; private set; } = orderBy;
    public XmlSortOrder SortOrder { get; set; } = sortOrder;
    public int? PageSize { get; private set; } = pageSize;
    public int? PageIndex { get; private set; } = pageIndex;
    public bool IsPagingEnabled => PageSize.HasValue && PageIndex.HasValue;
    #endregion

    #region Builder Helpers
    protected void AddCriteria(Expression<Func<T, bool>> criteria) => Criteria = criteria;

    protected void AddInclude(Expression<Func<T, object>> includeExpression)
    {
        Includes.Add(includeExpression);
    }
    protected void AddInclude(string includeString)
    {
        IncludeStrings.Add(includeString);
    }

    protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
    {
        OrderBy = orderByExpression;
        SortOrder = XmlSortOrder.Ascending;
    }

    protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
    {
        OrderBy = orderByDescExpression;
        SortOrder = XmlSortOrder.Descending;
    }

    protected void ApplyPaging(int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        PageSize = pageSize;
    }
    #endregion
    protected void AsSplitQuery()
    {
        QueryModifiers.Add(q => q.AsSplitQuery());
    }

    #region Pagination Helpers
    public int GetCount(IQueryable<T> query)
    {
        var filteredQuery = SpecificationEvaluator<T>.GetQuery(query, this, applyPaging: false);
        return filteredQuery.Count();
    }

    public async Task<int> GetCountAsync(IQueryable<T> query, CancellationToken cancellationToken = default)
    {
        var filteredQuery = SpecificationEvaluator<T>.GetQuery(query, this, applyPaging: false);
        return await filteredQuery.CountAsync(cancellationToken);
    }

    public int GetCount(IEnumerable<T> collection)
    {
        var query = collection.AsQueryable();
        return GetCount(query);
    }

    public int GetTotalPages(int totalCount)
    {
        if (!PageSize.HasValue || PageSize.Value <= 0)
            return 1;

        return (int)Math.Ceiling((double)totalCount / PageSize.Value);
    }

    public bool HasNextPage(int totalCount)
    {
        if (!IsPagingEnabled)
            return false;

        var totalPages = GetTotalPages(totalCount);
        return PageIndex!.Value + 1 < totalPages;
    }

    public bool HasPreviousPage()
    {
        return IsPagingEnabled && PageIndex!.Value > 1;
    }
    #endregion


    #region Logical Operators
    public static Specification<T> operator &(Specification<T> left, Specification<T> right) =>
        new AndSpecification<T>(left, right);

    public static Specification<T> operator |(Specification<T> left, Specification<T> right) =>
        new OrSpecification<T>(left, right);

    public static Specification<T> operator !(Specification<T> specification) =>
        new NotSpecification<T>(specification);
    #endregion

    #region Specification Application
    public IQueryable<T> ApplySpecification(IQueryable<T> query, bool applyPaging = true)
    {
        return SpecificationEvaluator<T>.GetQuery(query, this, applyPaging);
    }
    #endregion
}

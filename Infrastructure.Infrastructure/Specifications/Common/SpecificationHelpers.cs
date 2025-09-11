using ReelsCommerceSystem.Domain.Common;
using System.Linq.Expressions;

namespace ReelsCommerceSystem.Infrastructure.Specifications.Common;

internal class AndSpecification<T> : Specification<T> where T : BaseEntity
{
    public AndSpecification(ISpecification<T> left, ISpecification<T> right)
    {
        var leftExpr = left.Criteria;
        var rightExpr = right.Criteria;

        if (leftExpr != null && rightExpr != null)
        {
            var parameter = Expression.Parameter(typeof(T));
            var leftVisitor = new ReplaceExpressionVisitor(leftExpr.Parameters[0], parameter);
            var left2 = leftVisitor.Visit(leftExpr.Body);

            var rightVisitor = new ReplaceExpressionVisitor(rightExpr.Parameters[0], parameter);
            var right2 = rightVisitor.Visit(rightExpr.Body);

            AddCriteria(Expression.Lambda<Func<T, bool>>(Expression.AndAlso(left2, right2), parameter));
        }
        else if (leftExpr != null)
        {
            AddCriteria(leftExpr);
        }
        else if (rightExpr != null)
        {
            AddCriteria(rightExpr);
        }
    }
}

internal class OrSpecification<T> : Specification<T> where T : BaseEntity
{
    public OrSpecification(ISpecification<T> left, ISpecification<T> right)
    {
        var leftExpr = left.Criteria;
        var rightExpr = right.Criteria;

        if (leftExpr != null && rightExpr != null)
        {
            var parameter = Expression.Parameter(typeof(T));
            var leftVisitor = new ReplaceExpressionVisitor(leftExpr.Parameters[0], parameter);
            var left2 = leftVisitor.Visit(leftExpr.Body);

            var rightVisitor = new ReplaceExpressionVisitor(rightExpr.Parameters[0], parameter);
            var right2 = rightVisitor.Visit(rightExpr.Body);

            AddCriteria(Expression.Lambda<Func<T, bool>>(Expression.OrElse(left2, right2), parameter));
        }
    }
}

internal class NotSpecification<T> : Specification<T> where T : BaseEntity
{
    public NotSpecification(ISpecification<T> specification)
    {
        if (specification.Criteria != null)
        {
            var parameter = Expression.Parameter(typeof(T));
            var visitor = new ReplaceExpressionVisitor(specification.Criteria.Parameters[0], parameter);
            var body = visitor.Visit(specification.Criteria.Body);
            AddCriteria(Expression.Lambda<Func<T, bool>>(Expression.Not(body), parameter));
        }
    }
}

internal class ReplaceExpressionVisitor : ExpressionVisitor
{
    private readonly Expression _oldValue;
    private readonly Expression _newValue;

    public ReplaceExpressionVisitor(Expression oldValue, Expression newValue)
    {
        _oldValue = oldValue;
        _newValue = newValue;
    }

    public override Expression Visit(Expression node)
    {
        return node == _oldValue ? _newValue : base.Visit(node);
    }
}
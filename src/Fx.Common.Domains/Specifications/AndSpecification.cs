// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;
using System.Linq.Expressions;

namespace Fx.Common.Domains.Specifications;

/// <summary>
/// A type of specification object created by combining two specifications using the AND operator.
/// </summary>
/// <typeparam name="TEntity">Type of the domain entity.</typeparam>
public sealed class AndSpecification<TEntity> :
    BaseSpecification<TEntity>,
    ISpecification<TEntity>
    where TEntity : class, IEntity
{
    private readonly ISpecification<TEntity> left;
    private readonly ISpecification<TEntity> right;

    /// <summary>
    /// Initializes a new instance of the <see cref="AndSpecification{TEntity}"/> class.
    /// </summary>
    /// <param name="left">The left operand.</param>
    /// <param name="right">The right operand.</param>
    public AndSpecification(ISpecification<TEntity> left, ISpecification<TEntity> right)
    {
        this.left = left;
        this.right = right;
    }

    /// <inheritdoc/>
    public override bool IsSatisfiedBy(TEntity instance)
        => this.left.IsSatisfiedBy(instance) && this.right.IsSatisfiedBy(instance);

    /// <inheritdoc/>
    public override Expression<Func<TEntity, bool>> Export()
    {
        var leftExpression = this.left.Export();
        var rightExpression = this.right.Export();
        var invokedRight = Expression.Invoke(rightExpression, leftExpression.Parameters);
        var body = Expression.AndAlso(leftExpression.Body, invokedRight);
        return Expression.Lambda<Func<TEntity, bool>>(body, leftExpression.Parameters);
    }
}

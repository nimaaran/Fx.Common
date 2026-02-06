// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;
using System.Linq.Expressions;

namespace Fx.Common.Domains.Specifications;

/// <summary>
/// A type of specification object created by reversing a specification using the NOT operator.
/// </summary>
/// <typeparam name="TEntity">Type of the domain entity.</typeparam>
public sealed class NotSpecification<TEntity> :
    BaseSpecification<TEntity>,
    ISpecification<TEntity>
    where TEntity : class, IEntity
{
    private readonly ISpecification<TEntity> specification;

    /// <summary>
    /// Initializes a new instance of the <see cref="NotSpecification{TEntity}"/> class.
    /// </summary>
    /// <param name="specification">The operand.</param>
    public NotSpecification(ISpecification<TEntity> specification)
    {
        this.specification = specification;
    }

    /// <inheritdoc/>
    public override bool IsSatisfiedBy(TEntity instance)
        => !this.specification.IsSatisfiedBy(instance);

    /// <inheritdoc/>
    public override Expression<Func<TEntity, bool>> Export()
    {
        var expression = this.specification.Export();
        var reverseExpression = Expression.Not(expression.Body);
        return Expression.Lambda<Func<TEntity, bool>>(reverseExpression, expression.Parameters);
    }
}

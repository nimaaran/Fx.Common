// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;
using System.Linq.Expressions;

namespace Fx.Common.Domains.Specifications;

/// <summary>
/// A base class for specification classes.
/// </summary>
/// <typeparam name="TEntity">Type of the entity.</typeparam>
public abstract class BaseSpecification<TEntity> : ISpecification<TEntity>
    where TEntity : class, IEntity
{
    /// <summary>
    /// Makes a reverse specification from the current specification object.
    /// </summary>
    /// <returns>A reversed specification object.</returns>
    public ISpecification<TEntity> Not()
        => new NotSpecification<TEntity>(this);

    /// <summary>
    /// Combines the current specification with another specification object using OR operator.
    /// </summary>
    /// <param name="specification">
    /// Another specification object that should be combined with the current object.
    /// </param>
    /// <returns>The new specification object.</returns>
    public ISpecification<TEntity> Or(ISpecification<TEntity> specification)
        => new OrSpecification<TEntity>(this, specification);

    /// <summary>
    /// Combines the current specification with another specification object using AND operator.
    /// </summary>
    /// <param name="specification">
    /// Another specification object that should be combined with the current object.
    /// </param>
    /// <returns>The new specification object.</returns>
    public ISpecification<TEntity> And(ISpecification<TEntity> specification)
        => new AndSpecification<TEntity>(this, specification);

    /// <inheritdoc/>
    public abstract bool IsSatisfiedBy(TEntity instance);

    /// <inheritdoc/>
    public abstract Expression<Func<TEntity, bool>> Export();
}

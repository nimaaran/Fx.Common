// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;

namespace Fx.Common.Domains.Aggregates;

/// <summary>
/// A base class for aggregate root entity classes.
/// </summary>
/// <typeparam name="TId">Type of the aggregate root's id.</typeparam>
/// <typeparam name="TKey">Type of the aggregate key.</typeparam>
public abstract class BaseAggregateRoot<TId, TKey> : BaseEntity<TId>, IAggregateRoot<TId, TKey>
    where TId : notnull
    where TKey : notnull, IAggregateKey
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseAggregateRoot{TId, TKey}"/> class.
    /// </summary>
    /// <param name="key">See <see cref="IAggregateRoot{TKey}.Key"/>.</param>
    protected BaseAggregateRoot(TKey key)
        : base()
    {
        this.Key = key;
        this.Lock = new AggregateLock();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseAggregateRoot{TId, TKey}"/> class.
    /// </summary>
    /// <param name="id">See <see cref="IEntity{TId}.Id"/>.</param>
    /// <param name="removed">See <see cref="IEntity.Removed"/>.</param>
    /// <param name="key">See <see cref="IAggregateRoot{TKey}.Key"/>.</param>
    /// <param name="lock">See <see cref="IAggregateRoot.Lock"/>.</param>
    protected BaseAggregateRoot(TId id, bool removed, TKey key, AggregateLock @lock)
        : base(id, removed)
    {
        this.Key = key;
        this.Lock = @lock;
    }

    /// <inheritdoc/>
    public TKey Key { get; private set; }

    /// <inheritdoc/>
    public AggregateLock Lock { get; private set; }

    /// <inheritdoc/>
    public void UpdateLock(int numberOfChanges)
        => this.Lock = this.Lock.Update(numberOfChanges);
}

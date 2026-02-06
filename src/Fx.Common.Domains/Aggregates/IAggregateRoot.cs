// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;

namespace Fx.Common.Domains.Aggregates;

/// <summary>
/// A contract for aggregate root entity classes.
/// </summary>
public interface IAggregateRoot : IEntity
{
    /// <summary>
    /// Gets the aggregate lock object. This lock should be used when updating the aggregate to
    /// prevent concurrency issues.
    /// </summary>
    AggregateLock Lock { get; }

    /// <summary>
    /// Updates the aggregate lock's object according to the number of committed changes. This
    /// method should when a transactional save action is performing in the data context (UOW).
    /// </summary>
    /// <param name="numberOfChanges">The number of changes occurred in the aggregate.</param>
    void UpdateLock(int numberOfChanges);
}

/// <summary>
/// A contract for aggregate root entity classes.
/// </summary>
/// <typeparam name="TKey">Type of the aggregate key.</typeparam>
public interface IAggregateRoot<out TKey> : IAggregateRoot
{
    /// <summary>
    /// Gets the aggregate key. Outside the domain, this key should be used to reference the
    /// aggregate instead of <see cref="IEntity{TId}.Id"/>.
    /// </summary>
    TKey Key { get; }
}

/// <summary>
/// A contract for aggregate root entity classes.
/// </summary>
/// <typeparam name="TId">Type of the aggregate root's Id.</typeparam>
/// <typeparam name="TKey">Type of the aggregate key.</typeparam>
public interface IAggregateRoot<out TId, out TKey> :
    IEntity<TId>,
    IAggregateRoot<TKey>
    where TId : notnull
    where TKey : notnull, IAggregateKey;

// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Domains.Entities;

/// <summary>
/// A base class for domain entity classes.
/// </summary>
/// <typeparam name="TId">Type of the entity id.</typeparam>
public abstract class BaseEntity<TId> : IEntity<TId>
    where TId : notnull
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntity{TId}"/> class. This constructor is
    /// used by EF and reflection-based functionalities or when a new instance of the entity is
    /// created.
    /// </summary>
    protected BaseEntity()
    {
        this.Id = default!;
        this.Removed = false;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseEntity{TId}"/> class.
    /// </summary>
    /// <param name="id">See <see cref="IEntity{TId}.Id"/>.</param>
    /// <param name="removed">See <see cref="IEntity.Removed"/>.</param>
    protected BaseEntity(TId id, bool removed)
    {
        this.Id = id;
        this.Removed = removed;
    }

    /// <inheritdoc/>
    public TId Id { get; private set; }

    /// <inheritdoc/>
    public bool Removed { get; private set; }

    /// <summary>
    /// Sets the <see cref="Removed"/> property and marks the object for removal. Object removal
    /// will be completed when you save your data context changes.
    /// </summary>
    protected void Remove() => this.Removed = true;
}

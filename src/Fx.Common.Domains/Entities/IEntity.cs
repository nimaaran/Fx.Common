// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Models;

namespace Fx.Common.Domains.Entities;

/// <summary>
/// A contract for domain entity classes.
/// </summary>
public interface IEntity : IDataModel
{
    /// <summary>
    /// Gets a value indicating whether the object is removed or not.
    /// </summary>
    bool Removed { get; }
}

/// <summary>
/// A contract for domain entity classes.
/// </summary>
/// <typeparam name="TId">Type of the entity id.</typeparam>
public interface IEntity<out TId> : IEntity
    where TId : notnull
{
    /// <summary>
    /// Gets the object's unique identity.
    /// </summary>
    TId Id { get; }
}

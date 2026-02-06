// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;

namespace Fx.Common.Domains.Repositories;

/// <summary>
/// A contract for repository classes that removes an existing record in the data context.
/// </summary>
/// <typeparam name="TEntity">Type of the entity.</typeparam>
public interface IRecordRemover<in TEntity> : IRepository
    where TEntity : class, IEntity
{
    /// <summary>
    /// Removes an existing record in the repository's data context.
    /// </summary>
    /// <param name="entity">An record that should be removed.</param>
    void Remove(TEntity entity);
}

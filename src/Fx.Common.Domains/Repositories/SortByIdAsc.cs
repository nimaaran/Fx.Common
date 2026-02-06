// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;

namespace Fx.Common.Domains.Repositories;

/// <summary>
/// A sorter class that configs a query to sort the result by the Id column in ascending direction.
/// </summary>
/// <typeparam name="TEntity">Type of the entity.</typeparam>
/// <typeparam name="TId">Type of the entity id.</typeparam>
public class SortByIdAsc<TEntity, TId> : Sorter<TEntity>
    where TEntity : class, IEntity<TId>
    where TId : notnull
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SortByIdAsc{TEntity, TId}"/> class.
    /// </summary>
    public SortByIdAsc()
        : base(direction: SortingDirections.ASCENDING, column: r => r.Id)
    {
    }
}

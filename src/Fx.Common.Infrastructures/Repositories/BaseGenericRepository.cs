// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;
using Fx.Common.Domains.Repositories;
using Fx.Common.Domains.Specifications;
using Fx.Common.Infrastructures.DataContexts;

namespace Fx.Common.Infrastructures.Repositories;

/// <summary>
/// A base generic class for domain repositories.
/// </summary>
/// <typeparam name="TEntity">Type of the domain entity.</typeparam>
public abstract class BaseGenericRepository<TEntity>
    where TEntity : class, IEntity
{
    private readonly IDataContext dataContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseGenericRepository{TEntity}"/> class.
    /// </summary>
    /// <param name="dataContext">A data context provider.</param>
    protected BaseGenericRepository(IDataContext dataContext)
        => this.dataContext = dataContext;

    /// <summary>
    /// Adds a new entity record to the repository's data context.
    /// </summary>
    /// <param name="entity">A new record that should be added to database.</param>
    protected void Create(TEntity entity)
        => this.dataContext.AddRecord(entity);

    /// <summary>
    /// Updates an existing record in the repository's data context.
    /// </summary>
    /// <param name="entity">An record that should be updated.</param>
    protected void Modify(TEntity entity)
        => this.dataContext.UpdateRecord(entity);

    /// <summary>
    /// Removes an existing record in the repository's data context.
    /// </summary>
    /// <param name="entity">An record that should be removed.</param>
    protected void Remove(TEntity entity)
        => this.dataContext.DeleteRecord(entity);

    /// <summary>
    /// Runs a query and returns a list of records.
    /// </summary>
    /// <param name="pageSize">The number of records to be returned.</param>
    /// <param name="pageIndex">The index of a page to be returned in the result.</param>
    /// <param name="sorter">An object that specifies how records should be ordered.</param>
    /// <param name="specification">A specification that should be used to make a criteria.</param>
    /// <param name="token">See <see cref="CancellationToken"/>.</param>
    /// <returns>An async operation that returns a list of records.</returns>
    protected Task<List<TEntity>> ReadAsync(
        int pageSize,
        int pageIndex,
        Sorter<TEntity> sorter,
        ISpecification<TEntity> specification,
        CancellationToken token)
        => this.dataContext.GetRecordsAsync(pageSize, pageIndex, sorter, specification, token);
}

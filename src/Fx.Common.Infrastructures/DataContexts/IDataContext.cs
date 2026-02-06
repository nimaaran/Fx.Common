// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;
using Fx.Common.Domains.Repositories;
using Fx.Common.Domains.Specifications;
using Fx.Common.Models;

namespace Fx.Common.Infrastructures.DataContexts;

/// <summary>
/// Defines a contract for data contexts providers.
/// </summary>
public interface IDataContext
{
    /// <summary>
    /// Gets the relevant repository model according to the specified data model.
    /// </summary>
    /// <typeparam name="TModel">Type of the domain's data model.</typeparam>
    /// <returns>The relevant queryable repository model.</returns>
    IQueryable<TModel> GetDataModel<TModel>()
        where TModel : class, IDataModel;

    /// <summary>
    /// Gets a read-only list of tracked objects.
    /// </summary>
    /// <returns>A read-only list of objects tracked by the change tracker.</returns>
    IReadOnlyCollection<IDataModel> GetTrackedObjects();

    /// <summary>
    /// Introduce a record to the data context's change tracker for adding.
    /// </summary>
    /// <typeparam name="TEntity">Type of the entity object.</typeparam>
    /// <param name="instance">An object that should be added.</param>
    void AddRecord<TEntity>(TEntity instance)
        where TEntity : class, IEntity;

    /// <summary>
    /// Introduce a record to the data context's change tracker for updating.
    /// </summary>
    /// <typeparam name="TEntity">Type of the entity object.</typeparam>
    /// <param name="instance">An object that should be updated.</param>
    void UpdateRecord<TEntity>(TEntity instance)
        where TEntity : class, IEntity;

    /// <summary>
    /// Introduce a record to the data context's change tracker for removal.
    /// </summary>
    /// <typeparam name="TEntity">Type of the entity object.</typeparam>
    /// <param name="instance">An object that should be removed.</param>
    void DeleteRecord<TEntity>(TEntity instance)
        where TEntity : class, IEntity;

    /// <summary>
    /// Runs a query and retrieves a list of records.
    /// </summary>
    /// <typeparam name="TModel">Type of the query data model.</typeparam>
    /// <param name="pageSize">The number of records to be returned.</param>
    /// <param name="pageIndex">The index of a page to be returned in the result.</param>
    /// <param name="sorter">
    /// An object that specifies how records should be ordered.
    /// </param>
    /// <param name="specification">A specification that should be used to make a criteria.</param>
    /// <param name="token">See <see cref="CancellationToken"/>.</param>
    /// <returns>An async operation that returns a list of records.</returns>
    Task<List<TModel>> GetRecordsAsync<TModel>(
        int pageSize,
        int pageIndex,
        Sorter<TModel> sorter,
        ISpecification<TModel> specification,
        CancellationToken token)
        where TModel : class, IDataModel;

    /// <summary>
    /// Saves all data context changes.
    /// </summary>
    /// <param name="token">See <see cref="CancellationToken"/>.</param>
    /// <returns>An async operation that returns the number of affected rows.</returns>
    Task<int> SaveChangesAsync(CancellationToken token = default);
}

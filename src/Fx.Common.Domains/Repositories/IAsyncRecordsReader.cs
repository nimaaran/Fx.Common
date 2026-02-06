// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Specifications;
using Fx.Common.Models;

namespace Fx.Common.Domains.Repositories;

/// <summary>
/// A contract for repository classes that retrieve records from the database.
/// </summary>
/// <typeparam name="TModel">Type of the entity.</typeparam>
public interface IAsyncRecordsReader<TModel> : IRepository
    where TModel : class, IDataModel
{
    /// <summary>
    /// Runs a query and returns a list of records.
    /// </summary>
    /// <param name="pageSize">The number of records to be returned.</param>
    /// <param name="pageIndex">The index of a page to be returned in the result.</param>
    /// <param name="sorter">An object that specifies how records should be ordered.</param>
    /// <param name="specification">A specification that should be used to make a criteria.</param>
    /// <param name="token">See <see cref="CancellationToken"/>.</param>
    /// <returns>An async operation that returns a list of records.</returns>
    Task<List<TModel>> ReadAsync(
        int pageSize,
        int pageIndex,
        Sorter<TModel> sorter,
        ISpecification<TModel> specification,
        CancellationToken token);
}

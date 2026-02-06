// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Models;
using System.Linq.Expressions;

namespace Fx.Common.Domains.Repositories;

/// <summary>
/// A sorting definition object.
/// </summary>
/// <typeparam name="TModel">Type of the query data model.</typeparam>
public class Sorter<TModel>
    where TModel : class, IDataModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Sorter{TModel}"/> class.
    /// </summary>
    /// <param name="direction">See <see cref="Direction"/>.</param>
    /// <param name="column">See <see cref="Column"/>.</param>
    /// <param name="next">See <see cref="Next"/>.</param>
    public Sorter(
        SortingDirections direction,
        Expression<Func<TModel, object>> column,
        Sorter<TModel>? next = null)
    {
        this.Direction = direction;
        this.Column = column;
        this.Next = next;
    }

    /// <summary>
    /// Gets the sorting direction.
    /// </summary>
    public SortingDirections Direction { get; }

    /// <summary>
    /// Gets the expression indicating which column should be used for sorting.
    /// </summary>
    public Expression<Func<TModel, object>> Column { get; }

    /// <summary>
    /// Gets the next sort definition when more than one columns are involved in sorting.
    /// </summary>
    public Sorter<TModel>? Next { get; private set; }

    /// <summary>
    /// Sets the next sort definition.
    /// </summary>
    /// <param name="next">See <see cref="Next"/>.</param>
    /// <returns>The complete sort definition object.</returns>
    public Sorter<TModel> ThenBy(Sorter<TModel> next)
    {
        this.Next = next;
        return this;
    }
}

// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Models;
using System.Linq.Expressions;

namespace Fx.Common.Domains.Specifications;

/// <summary>
/// A contract for specification classes.
/// </summary>
/// <typeparam name="TModel">Type of the specification model.</typeparam>
public interface ISpecification<TModel>
    where TModel : class, IDataModel
{
    /// <summary>
    /// Indicates whether the specification is satisfied by the given object or not.
    /// </summary>
    /// <param name="instance">An object that should be evaluated.</param>
    /// <returns>
    /// <see langword="true"/> if the specification is satisfied by the given object; otherwise it
    /// returns <see langword="false"/>.
    /// </returns>
    bool IsSatisfiedBy(TModel instance);

    /// <summary>
    /// Converts the specification to a Linq expression.
    /// </summary>
    /// <returns>The equivalent Linq expression.</returns>
    Expression<Func<TModel, bool>> Export();
}

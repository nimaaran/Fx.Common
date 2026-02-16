// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Aggregates;
using Fx.Common.Services;

namespace Fx.Common.Domains.Policies;

/// <summary>
/// A contract for aggregate-based domain policy binders.
/// </summary>
/// <typeparam name="TAggregateRoot">Type of the aggregate root.</typeparam>
public interface IDomainPolicyBinder<in TAggregateRoot> : ISingletonService
    where TAggregateRoot : class, IAggregateRoot
{
    /// <summary>
    /// Binds a domain policy to an aggregate root object.
    /// </summary>
    /// <param name="instance">An instance of the aggregate root.</param>
    void Bind(TAggregateRoot instance);
}

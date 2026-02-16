// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Aggregates;

namespace Fx.Common.Domains.Policies;

#pragma warning disable S2326 // Unused type parameters should be removed.

/// <summary>
/// A marker interface used to introduce domain policies.
/// </summary>
public interface IDomainPolicy;

/// <summary>
/// A marker interface used to introduce aggregate-based domain policies.
/// </summary>
/// <typeparam name="TAggregateRoot">Type of the aggregate root.</typeparam>
public interface IDomainPolicy<TAggregateRoot> : IDomainPolicy
    where TAggregateRoot : IAggregateRoot;

#pragma warning restore S2326 // Unused type parameters should be removed.

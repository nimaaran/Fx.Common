// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Aggregates;
using Fx.Common.Services;

namespace Fx.Common.Domains.Services;

/// <summary>
/// A contract for aggregate key generators.
/// </summary>
/// <typeparam name="TKey">Type of the aggregate key.</typeparam>
public interface IAggregateKeyGenerator<out TKey> : IDomainService, ISingletonService
    where TKey : notnull, IAggregateKey
{
    /// <summary>
    /// Generates a new aggregate key.
    /// </summary>
    /// <returns>A new aggregate key.</returns>
    TKey Generate();
}

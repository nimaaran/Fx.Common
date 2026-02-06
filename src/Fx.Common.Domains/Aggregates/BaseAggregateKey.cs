// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Domains.Aggregates;

/// <summary>
/// A base class for aggregate key classes.
/// </summary>
/// <typeparam name="TValue">Type of the aggregate key's actual value.</typeparam>
/// <param name="Value">Actual value of the aggregate key.</param>
public abstract record class BaseAggregateKey<TValue>(TValue Value) : IAggregateKey<TValue>
    where TValue : notnull
{
    /// <inheritdoc/>
    public abstract bool IsValid();
}

// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Domains.Aggregates;

/// <summary>
/// A marker interface used to introduce aggregate keys.
/// </summary>
public interface IAggregateKey;

/// <summary>
/// A contract for domain aggregate keys.
/// </summary>
/// <typeparam name="TValue">Type of the key's actual value.</typeparam>
public interface IAggregateKey<out TValue> : IAggregateKey
    where TValue : notnull
{
    /// <summary>
    /// Gets the actual value of the aggregate key.
    /// </summary>
    TValue Value { get; }

    /// <summary>
    /// Validates the key's actual value.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if the key is valid; otherwise it returns <see langword="false"/>.
    /// </returns>
    bool IsValid();
}

// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Domains.Aggregates;

/// <summary>
/// A base class for Guid aggregate keys.
/// </summary>
/// <param name="Value">The value of the key.</param>
public abstract record class BaseGuidAggregateKey(Guid Value) : BaseAggregateKey<Guid>(Value)
{
    /// <inheritdoc/>
    public override bool IsValid()
    {
        return !this.Value.Equals(Guid.Empty);
    }
}

// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Services;

/// <summary>
/// A default implementation for <see cref="IGuidGenerator"/>.
/// </summary>
public sealed class BasicGuidGenerator : IGuidGenerator
{
    /// <inheritdoc/>
    public Guid Generate() => System.Guid.NewGuid();
}

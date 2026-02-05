// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Services;

/// <summary>
/// A contract for <see cref="System.Guid"/> providers.
/// </summary>
public interface IGuidGenerator : ISingletonService
{
    /// <summary>
    /// Generates a new value as type of the <see cref="System.Guid"/>.
    /// </summary>
    /// <returns>A new <see cref="System.Guid"/> value.</returns>
    Guid Generate();
}

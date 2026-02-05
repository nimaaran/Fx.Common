// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Exceptions;
using Fx.Common.Services;

namespace Fx.Common.Helpers;

/// <summary>
/// A global helper for working with <see cref="System.Guid"/> values easier.
/// </summary>
public static class GuidHelper
{
    /// <summary>
    /// Generates a new <see cref="GuidHelper"/> value.
    /// </summary>
    /// <returns>A new <see cref="GuidHelper"/> value.</returns>
    public static Guid Generate()
    {
        var provider = ServiceResolver.Resolve<IGuidGenerator>()
                       ?? throw new OperationFailedException("No Guid provider resolved.");

        return provider.Generate();
    }
}

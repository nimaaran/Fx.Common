// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Services;

/// <summary>
/// A contract for <see cref="DateTimeOffset"/> providers.
/// </summary>
public interface IDateTimeProvider : ISingletonService
{
    /// <summary>
    /// Gets a System.DateTimeOffset object that is set to the current date and time on the current
    /// computer, with the offset set to the local time's offset from Coordinated Universal Time.
    /// </summary>
    DateTimeOffset Now { get; }

    /// <summary>
    /// Gets a System.DateTimeOffset object whose date and time are set to the current Coordinated
    /// Universal Time (UTC) date and time and whose offset is System.TimeSpan.Zero.
    /// </summary>
    DateTimeOffset UtcNow { get; }
}

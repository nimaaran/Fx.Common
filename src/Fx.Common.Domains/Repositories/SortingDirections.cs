// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Domains.Repositories;

/// <summary>
/// Defines different records sorting directions.
/// </summary>
public enum SortingDirections : byte
{
    /// <summary>
    /// For sorting records from lowest to highest values.
    /// </summary>
    ASCENDING = 1,

    /// <summary>
    /// For sorting records from highest to lowest values.
    /// </summary>
    DESCENDING = 2,
}

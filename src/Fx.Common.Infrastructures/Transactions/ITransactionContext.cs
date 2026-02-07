// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Infrastructures.Transactions;

/// <summary>
/// A contract for transaction contexts (unit-of-work).
/// </summary>
public interface ITransactionContext
{
    /// <summary>
    /// Saves all pending changes in database within a single transaction.
    /// </summary>
    /// <param name="token">See <see cref="CancellationToken"/>.</param>
    /// <returns>An async operation that returns the number of affected rows.</returns>
    Task<int> CommitAsync(CancellationToken token = default);
}

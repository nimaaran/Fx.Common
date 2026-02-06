// ------------------------------------------------------------------------------------------------
// Copyright (c) 2026. All Rights Reserved.
// This software is proprietary and confidential. Unauthorized use, modification or distribution is
// strictly prohibited. Read the LICENSE file or contact us for licensing inquiries.
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

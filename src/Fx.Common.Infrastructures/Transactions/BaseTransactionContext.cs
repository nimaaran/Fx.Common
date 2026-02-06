// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Infrastructures.DataContexts;

namespace Fx.Common.Infrastructures.Transactions;

/// <summary>
/// A base class for transaction contexts (unit-of-work).
/// </summary>
public abstract class BaseTransactionContext : ITransactionContext
{
    private readonly IDataContext dataContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseTransactionContext"/> class.
    /// </summary>
    /// <param name="dataContext">A database context provider.</param>
    protected BaseTransactionContext(IDataContext dataContext)
    {
        this.dataContext = dataContext;
    }

    /// <inheritdoc/>
    public Task<int> CommitAsync(CancellationToken token = default)
    {
        return this.dataContext.SaveChangesAsync(token);
    }
}

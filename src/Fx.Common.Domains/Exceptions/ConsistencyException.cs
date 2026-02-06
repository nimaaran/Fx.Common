// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Domains.Exceptions;

/// <summary>
/// A domain-specific exception used when executing an operation could leave the system in an
/// inconsistent state. In this case, the input parameters are valid, but executing the operation
/// would violate a business rule.
/// </summary>
public sealed class ConsistencyException : BaseDomainException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConsistencyException"/> class.
    /// </summary>
    /// <param name="message">See <see cref="Exception.Message"/>.</param>
    public ConsistencyException(string? message)
        : base(message)
    {
    }
}

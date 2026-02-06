// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Exceptions;

namespace Fx.Common.Domains.Exceptions;

/// <summary>
/// A base class for domain-specific exception types in Fx-based applications.
/// </summary>
public abstract class BaseDomainException : BaseException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseDomainException"/> class.
    /// </summary>
    protected BaseDomainException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseDomainException"/> class.
    /// </summary>
    /// <param name="message">See <see cref="Exception.Message"/>.</param>
    protected BaseDomainException(string? message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseDomainException"/> class.
    /// </summary>
    /// <param name="message">See <see cref="Exception.Message"/>.</param>
    /// <param name="innerException">See <see cref="Exception.InnerException"/>.</param>
    protected BaseDomainException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }
}

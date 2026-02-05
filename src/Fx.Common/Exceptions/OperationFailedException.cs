// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Exceptions;

/// <summary>
/// A general-purpose exception type is used when an operation cannot be completed due to a handled
/// or well-known error.
/// </summary>
public sealed class OperationFailedException : BaseException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OperationFailedException"/> class.
    /// </summary>
    public OperationFailedException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OperationFailedException"/> class.
    /// </summary>
    /// <param name="message">See <see cref="Exception.Message"/>.</param>
    public OperationFailedException(string? message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OperationFailedException"/> class.
    /// </summary>
    /// <param name="message">See <see cref="Exception.Message"/>.</param>
    /// <param name="innerException">See <see cref="Exception.InnerException"/>.</param>
    public OperationFailedException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }
}

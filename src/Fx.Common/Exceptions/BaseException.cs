// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Exceptions;

/// <summary>
/// A base class for custom exception types is defined in Fx-based applications. For improved error
/// handling and logging of business-specific exceptions, derive your custom exception classes from
/// this base class or from its existing derived classes.
/// </summary>
public abstract class BaseException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseException"/> class.
    /// </summary>
    protected BaseException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseException"/> class.
    /// </summary>
    /// <param name="message">See <see cref="Exception.Message"/>.</param>
    protected BaseException(string? message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BaseException"/> class.
    /// </summary>
    /// <param name="message">See <see cref="Exception.Message"/>.</param>
    /// <param name="innerException">See <see cref="Exception.InnerException"/>.</param>
    protected BaseException(string? message, Exception? innerException)
        : base(message, innerException)
    {
    }
}

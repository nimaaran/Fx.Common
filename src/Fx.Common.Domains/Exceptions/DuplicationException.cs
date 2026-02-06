// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;

namespace Fx.Common.Domains.Exceptions;

/// <summary>
/// A domain-specific exception type used when an object already exists in the system.
/// </summary>
/// <typeparam name="TEntity">Type of the domain entity.</typeparam>
public sealed class DuplicationException<TEntity> : BaseDomainException
    where TEntity : class, IEntity
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DuplicationException{TEntity}"/> class.
    /// </summary>
    /// <param name="attribute">An attribute name used for duplication control.</param>
    /// <param name="value">An attribute value used for duplication control.</param>
    public DuplicationException(string attribute, object value)
        : base($"A same {typeof(TEntity).Name} with the {attribute} " +
               $"{value} already exists.")
    {
    }
}

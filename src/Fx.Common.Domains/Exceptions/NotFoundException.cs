// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;

namespace Fx.Common.Domains.Exceptions;

/// <summary>
/// A domain-specific exception used when an object does not exist in the system.
/// </summary>
/// <typeparam name="TEntity">Type of the domain entity.</typeparam>
public class NotFoundException<TEntity> : BaseDomainException
    where TEntity : class, IEntity
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NotFoundException{TEntity}"/> class.
    /// </summary>
    /// <param name="attribute">The name of an attribute used to find an object.</param>
    /// <param name="value">The value of the attribute of missed object.</param>
    public NotFoundException(string attribute, object value)
        : base($"There is no object as type of {typeof(TEntity).Name} with the {attribute} " +
               $"{value}.")
    {
    }
}

// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Domains.Entities;

namespace Fx.Common.Domains.Exceptions;

/// <summary>
/// A domain-specific exception used when changing the state of an object is invalid.
/// </summary>
/// <typeparam name="TEntity">Type of the entity.</typeparam>
/// <typeparam name="TState">Type of the state-machine property.</typeparam>
public sealed class StateTransitionException<TEntity, TState> : BaseDomainException
    where TEntity : class, IEntity
    where TState : notnull
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StateTransitionException{TEntity, TState}"/>
    /// class.
    /// </summary>
    /// <param name="currentState">The current state of the object.</param>
    /// <param name="newState">Intended object state.</param>
    /// <param name="attribute">The name of an attribute used to mention an object.</param>
    /// <param name="value">The value of the attribute of mentioned object.</param>
    public StateTransitionException(
        TState currentState,
        TState newState,
        string attribute,
        object value)
        : base($"State transition for an object as type of {typeof(TEntity).Name} with the " +
               $"{attribute} {value} from {Enum.GetName(typeof(TState), currentState)!} " +
               $" to {Enum.GetName(typeof(TState), newState)!} failed.")
    {
    }
}

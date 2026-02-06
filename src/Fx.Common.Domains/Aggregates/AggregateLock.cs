// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Services;

namespace Fx.Common.Domains.Aggregates;

/// <summary>
/// Fx-based applications use optimistic locking to prevent side effects from concurrent changes in
/// domain aggregates. This class defines an optimistic-lock's object type for this purpose.
/// </summary>
public sealed record class AggregateLock
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AggregateLock"/> class. This constructor is
    /// used to make a lock object for a new aggregates.
    /// </summary>
    public AggregateLock()
    {
        this.Timestamp = ServiceResolver.Resolve<IDateTimeProvider>()!.UtcNow;
        this.Version = 1;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AggregateLock"/> class. This constructor is
    /// used to reload an existing aggregate's lock object.
    /// </summary>
    /// <param name="timestamp">See <see cref="AggregateLock.Timestamp"/>.</param>
    /// <param name="counter">See <see cref="AggregateLock.Version"/>.</param>
    public AggregateLock(DateTimeOffset timestamp, int counter)
    {
        this.Timestamp = timestamp;
        this.Version = counter;
    }

    /// <summary>
    /// Gets a value indicating when the aggregate was last changed.
    /// </summary>
    public DateTimeOffset Timestamp { get; }

    /// <summary>
    /// Gets a value indicating how many times the aggregate has been changed. This value is
    /// incremented after each change.
    /// </summary>
    public int Version { get; }

    /// <summary>
    /// Creates a new lock using the current lock attributes.
    /// </summary>
    /// <param name="numberOfChanges">A number indicating how many changes have occurred.</param>
    /// <returns>A new lock object.</returns>
    public AggregateLock Update(int numberOfChanges)
    {
        var now = ServiceResolver.Resolve<IDateTimeProvider>()!.UtcNow;
        return new(now, this.Version + numberOfChanges);
    }
}

// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Exceptions;
using Microsoft.Extensions.DependencyInjection;

namespace Fx.Common.Services;

/// <summary>
/// A global service resolver for Fx-based applications that resolves service instances from the
/// dependency injection container.
/// </summary>
public static class ServiceResolver
{
    private static IServiceProvider? provider = null;

    /// <summary>
    /// Gets or sets the local service provider that exposes the dependency injection container.
    /// The setter allows the application to set the internal provider only once. Any subsequent
    /// attempt raises an exception, protecting the internal provider from further modification.
    /// </summary>
    public static IServiceProvider Provider
    {
        get
        {
            return provider! ?? throw new OperationFailedException("No service provider set.");
        }

        set
        {
            if (value is null)
            {
                throw new OperationFailedException("The service provider is invalid.");
            }
            else if (provider is not null)
            {
                throw new OperationFailedException("A service provider already set.");
            }

            provider = value;
        }
    }

    /// <summary>
    /// Resolves an instance of the specified service.
    /// </summary>
    /// <typeparam name="TService">Type of the intended service.</typeparam>
    /// <returns>
    /// If the service is already registered, this method returns an instance of the service;
    /// otherwise, it returns <see langword="null"/>.
    /// </returns>
    public static TService? Resolve<TService>()
        where TService : IService
        => ServiceResolver.Provider.GetService<TService>();
}

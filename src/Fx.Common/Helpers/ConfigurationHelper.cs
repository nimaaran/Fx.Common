// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Configuration;
using Fx.Common.Exceptions;
using Fx.Common.Services;

namespace Fx.Common.Helpers;

/// <summary>
/// A global helper for getting config models.
/// </summary>
public static class ConfigurationHelper
{
    /// <summary>
    /// Gets an instance of the settings object according to the specified config model.
    /// </summary>
    /// <typeparam name="TConfigModel">Type of the config model.</typeparam>
    /// <returns>An instance of the settings object.</returns>
    public static TConfigModel GetSettings<TConfigModel>()
        where TConfigModel : class, IConfigModel, new()
    {
        var configurationProvider = ServiceResolver.Resolve<IConfigProvider>() ??
            throw new OperationFailedException($"There is no instance as type of " +
                                               $"{typeof(TConfigModel).Name}");

        var settings = configurationProvider.Get<TConfigModel>() ??
            throw new OperationFailedException("There is no config for the specified model.");

        return settings;
    }
}

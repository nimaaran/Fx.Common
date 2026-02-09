// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Services;

namespace Fx.Common.Configuration;

/// <summary>
/// A contract for config provider services.
/// </summary>
public interface IConfigProvider : ISingletonService
{
    /// <summary>
    /// Gets an instance of config according to the specified config model.
    /// </summary>
    /// <typeparam name="TConfigModel">Type of the config model.</typeparam>
    /// <returns>An instance of the config object.</returns>
    TConfigModel Get<TConfigModel>()
        where TConfigModel : class, IConfigModel, new();
}

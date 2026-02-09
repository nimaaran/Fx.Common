// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Exceptions;
using Microsoft.Extensions.Configuration;
using System.Collections.Concurrent;
using System.Reflection;

namespace Fx.Common.Configuration;

/// <summary>
/// An implementation for <see cref="IConfigProvider"/>.
/// </summary>
public sealed class BasicConfigProvider : IConfigProvider
{
    private readonly IConfiguration configuration;
    private readonly ConcurrentDictionary<Type, object> cache = new();

    /// <summary>
    /// Initializes a new instance of the <see cref="BasicConfigProvider"/> class.
    /// </summary>
    /// <param name="configuration">An instance of the .NET configuration provider.</param>
    public BasicConfigProvider(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    /// <inheritdoc/>
    public TConfigModel Get<TConfigModel>()
        where TConfigModel : class, IConfigModel, new()
    {
        return (TConfigModel)this.cache.GetOrAdd(
            key: typeof(TConfigModel),
            valueFactory: _ => this.Create<TConfigModel>());
    }

    private static string GetSectionName(Type type)
    {
        var attribute = type.GetCustomAttribute<ConfigSectionAttribute>() ??
            throw new InvalidOperationException(
                $"Type '{type.Name}' does not declare ConfigSectionAttribute");

        return attribute.Name;
    }

    private TConfigModel Create<TConfigModel>()
        where TConfigModel : class
    {
        var sectionName = GetSectionName(typeof(TConfigModel));
        var section = this.configuration.GetSection(sectionName);

        if (!section.Exists())
        {
            throw new OperationFailedException($"Configuration section '{sectionName}' not found" +
                                               $" for '{typeof(TConfigModel).Name}'");
        }

        var instance = section.Get<TConfigModel>() ??
            throw new OperationFailedException($"Configuration section '{sectionName}' could" +
                                               $" not be bound to '{typeof(TConfigModel).Name}'");

        return instance;
    }
}

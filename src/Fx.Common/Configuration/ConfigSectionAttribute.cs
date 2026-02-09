// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Configuration;

/// <summary>
/// An attribute used to specify config section name of config model classes.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
public sealed class ConfigSectionAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigSectionAttribute"/> class.
    /// </summary>
    /// <param name="name">The name of the configuration section.</param>
    public ConfigSectionAttribute(string name)
    {
        this.Name = name;
    }

    /// <summary>
    /// Gets the section name.
    /// </summary>
    public string Name { get; }
}

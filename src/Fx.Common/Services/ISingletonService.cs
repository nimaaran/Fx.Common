// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

namespace Fx.Common.Services;

/// <summary>
/// A marker interface used to identify services that should be registered with singleton lifetime
/// in dependency injection.
/// </summary>
public interface ISingletonService : IService;

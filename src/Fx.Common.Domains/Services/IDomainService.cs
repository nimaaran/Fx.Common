// ------------------------------------------------------------------------------------------------
// All rights reserved. This project and this file is published under the Apache License 2. So, Any
// use of this project must comply with the terms and policies described in the project’s `LICENSE`
// file. For more information, please visit the project repository on GitHub or contact with owner.
// ------------------------------------------------------------------------------------------------

using Fx.Common.Services;

namespace Fx.Common.Domains.Services;

/// <summary>
/// A marker interface used to identify domain services. Domain services should not be exposed
/// outside the domain's boundaries.
/// </summary>
public interface IDomainService : IService;
